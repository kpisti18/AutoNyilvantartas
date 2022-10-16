using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoNyilvantartas
{
    internal static class Program
    {
        //4. az ablakok közötti váltogatás
        public static FormNyito formNyito = null;
        public static FormAuto formAuto = null;
        public static Adatbazis adatbazis = new Adatbazis(); //adatbáziskapcsolatot ha szeretnénk bárhol használni
        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //5. a formot felhasználhatóvá akarjuk tenni
            formNyito = new FormNyito();
            Application.Run(formNyito);
        }
    }
}
