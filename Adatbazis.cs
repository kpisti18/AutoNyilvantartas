using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;

namespace AutoNyilvantartas
{
    //2. Adatbáziskapcsolat leírása
    internal class Adatbazis
    {
        MySqlConnection con = null;
        MySqlCommand cmd = null;

        public Adatbazis(string host="localhost", string user="root", string password="", string database="autok")
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = host;
            builder.UserID = user;
            builder.Password = password;
            builder.Database = database;

            con = new MySqlConnection(builder.ConnectionString);
            con.Open();

            cmd = con.CreateCommand();

            con.Close();
        }

        //3. publikus lista létrehozása az adatbázisból függvénnyel
        public List<Auto> osszesAuto()
        {
            List<Auto> osszes = new List<Auto>();
            cmd.CommandText = "SELECT * FROM `auto`";

            con.Open();
            try
            {
                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        osszes.Add(new Auto(dr.GetUInt64("id"), dr.GetString("rendszam"), dr.GetString("marka"), dr.GetString("tipus"), dr.GetString("forgalombaHelyezes")));
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Az alábbi hiba lépett fel:\n{ex}");
            }

            con.Close();

            return osszes;
        }

        //10. Egy insert-et készítünk az adatbázis felé
        public void ujAuto(Auto auto)
        {
            //10.a Tegyünk bele hibakezelést
            try
            {
                con.Open();

                cmd.CommandText = $"INSERT INTO `auto`(`id`, `rendszam`, `marka`, `tipus`, `forgalombaHelyezes`) VALUES (NULL,'{auto.Rendszam.ToUpper()}','{auto.Marka}','{auto.Tipus}','{auto.ForgalombaHelyezes}')";

                cmd.ExecuteNonQuery();

                con.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Az alábbi hiba lépett fel:\n{ex}");
            }
        }

        //13/a. Update-et készítünk az adatbázis felé
        public void modositAuto(Auto auto)
        {
            try
            {
                con.Open();

                cmd.CommandText = $"UPDATE `auto` SET `rendszam`= '{auto.Rendszam}',`marka`= '{auto.Marka}',`tipus`= '{auto.Tipus}',`forgalombaHelyezes`= '{auto.ForgalombaHelyezes}' WHERE `id`= '{auto.Id}'";

                cmd.ExecuteNonQuery();

                con.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Az alábbi hiba lépett fel:\n{ex}");
            }
        }

        //14/b.
        public void torolAuto(Auto auto)
        {
            try
            {
                con.Open();

                cmd.CommandText = $"DELETE FROM `auto` WHERE `id`= {auto.Id}";

                cmd.ExecuteNonQuery();

                con.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Az alábbi hiba lépett fel:\n{ex}");
            }
        }
    }
}
