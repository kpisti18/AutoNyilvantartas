using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoNyilvantartas
{
    public partial class FormAuto : Form
    {
        string muvelet; //8/c. osztálváltozóba deklaráljuk
        private Auto kivalasztottAuto; //12/b. osztályváltozóként deklaráljuk

        public FormAuto(string muvelet) //8.a a konstruktor létrehozása
        {
            InitializeComponent();
            this.muvelet = muvelet; //8/d.
        }

        private void FormAuto_Load(object sender, EventArgs e)
        {
            //8/e. esetek megírása (új, módosítás, törlés)
            switch (muvelet)
            {
                case "insert":
                    btMuvelet.Text = "Új autó adatainak felvétele"; //gomb nevének megváltoztatása
                    this.Text = "Új autó adatainak felvétele"; //ablak nevének megváltoztatása
                    break;
                
                //12/a.
                case "update":
                    //hogy a kivalasztottAuto-hoz elérjük a formNyitó listboxából az adatokat, a design-ban át kell állítanunk a listbox modifier tulajdonságát public-ra, és még opcionálisan osztályszintű változóként deklaráljuk a kivalasztottAuto-t, mert a delete-nél is fel szeretnénk használni
                    kivalasztottAuto = (Auto)Program.formNyito.lbAdatok.SelectedItem;

                    //12.d
                    btMuvelet.Text = $"{kivalasztottAuto.Rendszam} rendszámú autó adatainak módosítása";
                    this.Text = $"{kivalasztottAuto.Rendszam} rendszámú autó adatainak módosítása";
                    tbID.Text = kivalasztottAuto.Id.ToString();
                    tbRendszam.Text = kivalasztottAuto.Rendszam;
                    tbMarka.Text = kivalasztottAuto.Marka;
                    tbTipus.Text = kivalasztottAuto.Tipus;
                    tbEv.Text = kivalasztottAuto.ForgalombaHelyezes;
                    break;

                case "delete":
                    kivalasztottAuto = (Auto)Program.formNyito.lbAdatok.SelectedItem;

                    btMuvelet.Text = $"{kivalasztottAuto.Rendszam} rendszámú autó adatainak törlése";
                    this.Text = $"{kivalasztottAuto.Rendszam} rendszámú autó adatainak törlése";
                    tbID.Text = kivalasztottAuto.Id.ToString();
                    tbRendszam.Text = kivalasztottAuto.Rendszam;
                    tbMarka.Text = kivalasztottAuto.Marka;
                    tbTipus.Text = kivalasztottAuto.Tipus;
                    tbEv.Text = kivalasztottAuto.ForgalombaHelyezes;
                    break;

                default:
                    break;
            }
        }

        // 9. ha ráklikkelünk az új/törlés/módosítás gombra
        private void btMuvelet_Click(object sender, EventArgs e)
        {
            switch (muvelet)
            {
                case "insert":
                    tbRendszam.Focus(); // a rendszám mezőn fog állni alapból
                    ujAutoRogzites(); //9/a. metódus létrehozása
                    break;
                
                //12/b.
                case "update":
                    tbRendszam.Focus();
                    //13.
                    autoFrissites();
                    break;
                
                //14/a.
                case "delete":
                    autoTorles();
                    break;

                default:
                    break;
            }
        }

        //14/c. -> a 14/b-hez menj az Adatbazis.cs-be
        private void autoTorles()
        {
            if (mezokKitoltottek())
            {
                Auto torles = new Auto(ulong.Parse(tbID.Text), tbRendszam.Text, tbMarka.Text, tbTipus.Text, tbEv.Text);
                Program.adatbazis.torolAuto(torles);
                MessageBox.Show("Sikeres törlés");
            }
            else
            {
                MessageBox.Show("Tölts ki minden mezőt!", "Hiba");
            }

            this.Close();
        }

        //13/b.  -> a 13/a-hoz menj az Adatbazis.cs-be
        private void autoFrissites()
        {
            if (mezokKitoltottek())
            {
                Auto modosit = new Auto(ulong.Parse(tbID.Text), tbRendszam.Text, tbMarka.Text, tbTipus.Text, tbEv.Text);
                Program.adatbazis.modositAuto(modosit);
                MessageBox.Show("Sikeres módosítás");
            }
            else
            {
                MessageBox.Show("Tölts ki minden mezőt!", "Hiba");
            }

            this.Close(); //ha sikerül, ha nem a rögzítés, bezárjuk az ablakot
        }

        // 9/a.
        private void ujAutoRogzites()
        {
            // 9/b. mezokKitoltottek metódus létrehozáa
            if (mezokKitoltottek())
            {
                //10. menj az Adatbazis osztályra
                //11. példányosítsuk az Autot
                //0-át adjunk meg az ID-nál, mivel az ID nem lehet null, az adatbázist úgy hoztam létre
                Auto uj = new Auto(0, tbRendszam.Text, tbMarka.Text, tbTipus.Text, tbEv.Text);
                Program.adatbazis.ujAuto(uj);
                MessageBox.Show("Sikeres felvétel");
            }
            else
            {
                MessageBox.Show("Tölts ki minden mezőt!", "Hiba");
            }

            this.Close(); //ha sikerül, ha nem a rögzítés, bezárjuk az ablakot
        }

        private bool mezokKitoltottek()
        {
            //9/b. ha az ID üres és a művelet nem beillesztés
            if (string.IsNullOrEmpty(tbID.Text) && !muvelet.Equals("insert"))
            {
                return false;
            }

            // ez majd kell a többi művelethez, minden mezőnek kitöltöttnek kell lennie
            if (string.IsNullOrEmpty(tbRendszam.Text) || string.IsNullOrEmpty(tbMarka.Text) || string.IsNullOrEmpty(tbTipus.Text) || string.IsNullOrEmpty(tbEv.Text))
            {
                return false;
            }

            return true;
        }
    }
}
