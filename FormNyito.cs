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
    public partial class FormNyito : Form
    {
        public FormNyito()
        {
            InitializeComponent();
        }

        // 6/c. adatok kilistázása az update metódussal a program indulásakor (most itt a combobox-ba csak az márkákat, egyfajta szűrés, ha rengeteg adatunk van)
        private void FormNyito_Load(object sender, EventArgs e)
        {
            cbUpdate();
            lbUpdate();  //15.
        }

        //15. teljes lista kirajzolása
        private void lbUpdate()
        {
            lbAdatok.Items.Clear();

            foreach (Auto item in Program.adatbazis.osszesAuto())
            {
                lbAdatok.Items.Add(item);
            }
        }

        // 6/a. update metódus létrehozása
        void cbUpdate()
        {
            cbAutok.Items.Clear();

            foreach (Auto item in Program.adatbazis.osszesAuto()) //osszesAuto függvény meghívása
            {
                // 6/b. duplikált elemek kiszűrése a combobox-ból
                if (!cbAutok.Items.Contains(item.Marka))
                {
                    cbAutok.Items.Add(item.Marka);
                }  
            }
        }

        // 7. listbox feltöltése (frisstíése) a kiválasztott márkához tartozó adatokkal, majd menj az Auto.cs-be, és írd felül a megjelenést a módosító metódussal
        private void cbAutok_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbAdatok.Items.Clear();

            foreach (Auto item in Program.adatbazis.osszesAuto())
            {
                if (cbAutok.SelectedItem.ToString().Equals(item.Marka))
                {
                    lbAdatok.Items.Add(item);
                }
            }  
        }

        // 8. az adatbázis bővítése új adatokkal
        private void btUj_Click(object sender, EventArgs e)
        {
            FormAuto formAuto = new FormAuto("insert"); // 8/a. az insertnek még nem létezik konstruktora, ezt hozzuk létre
            formAuto.ShowDialog(); //átugrunk a másik ablakra
            cbUpdate(); //visszaállítjuk a szűrést
            lbUpdate(); // 16.
        }

        // 11. a módosítás gombra klikkelés a nyitó-n, hasonló az új felvételéhez
        private void btModosit_Click(object sender, EventArgs e)
        {
            if (lbAdatok.SelectedIndex < 0) //ha nincs kiválasztott elem
            {
                MessageBox.Show("Nincs kiválasztott autó!", "Hiba");
                return;
            }

            FormAuto formAuto = new FormAuto("update");
            formAuto.ShowDialog();
            cbUpdate();
            lbUpdate(); // 16.
            //Ezután átmegyünk a FormAuto.cs-be
        }

        //14. törlés gomb
        private void btTorol_Click(object sender, EventArgs e)
        {
            if (lbAdatok.SelectedIndex < 0)
            {
                MessageBox.Show("Nincs kiválasztott autó!", "Hiba");
                return;
            }

            FormAuto formAuto = new FormAuto("delete");
            formAuto.ShowDialog();
            cbUpdate();
            lbUpdate(); // 16.
            //Ezután átmegyünk a FormAuto.cs-be
        }

        //16. Frissítés gomb
        private void btTeljesLista_Click(object sender, EventArgs e)
        {
            lbUpdate();
        }
    }
}
