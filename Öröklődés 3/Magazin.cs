using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Öröklődés_3
{
    internal class Magazin:Olvasmany
    {
        int szam;
        string temakor;

        public int Szam
        {
            get => szam;
            set => szam = value > 0 ? value : throw new Exception("Hiba: Csak pozitív lehet");
        }

        public string Temakor
        {
            get => temakor;
            set => temakor = string.IsNullOrEmpty(value) ? throw new Exception("Hiba: Nem lehet üres") : value;
        }

        //14.
        public Magazin(string cim, string szerzo, int kiadasEve, int szam, string temakor):base(cim, szerzo, kiadasEve)
        {
            Szam = szam;
            Temakor = temakor;
        }
        public Magazin(string cim, string szerzo, int szam, string temakor) : base(cim, szerzo)
        {
            Szam = szam;
            Temakor = temakor;
        }

        public override void Kiir()
        {
            base.Kiir();
            Console.WriteLine($"{Szam}. kiadas {Temakor} témakörben.");
        }
    }
}
