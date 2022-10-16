using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoNyilvantartas
{
    //1. egy auto leírása
    internal class Auto
    {
        readonly ulong id;
        string rendszam;
        string marka;
        string tipus;
        string forgalombaHelyezes;

        public ulong Id => id;
        public string Rendszam { get => rendszam; set => rendszam = value; }
        public string Marka { get => marka; set => marka = value; }
        public string Tipus { get => tipus; set => tipus = value; }
        public string ForgalombaHelyezes { get => forgalombaHelyezes; set => forgalombaHelyezes = value; }

        public Auto(ulong id, string rendszam, string marka, string tipus, string forgalombaHelyezes)
        {
            this.id = id;
            Rendszam = rendszam;
            Marka = marka;
            Tipus = tipus;
            ForgalombaHelyezes = forgalombaHelyezes;
        }

        //7/a.
        public override string ToString()
        {
            return $"Id: {id} || Rendszám: {rendszam} || Márka: {marka} || Típus: {tipus} || Forgalomba helyezés éve: {forgalombaHelyezes}";
        }
    }
}
