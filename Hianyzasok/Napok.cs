using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hianyzasok
{
    internal class Napok
    {
        public string nev, osztaly;
        public int elsoNap, utsoNap, orakSzama;

        public Napok(string sor)
        {
            string[] adatok = sor.Split(';');
            nev = adatok[0];
            osztaly = adatok[1];
            elsoNap = Convert.ToInt32(adatok[2]);
            utsoNap = Convert.ToInt32(adatok[3]);
            orakSzama = Convert.ToInt32(adatok[4]);
        }
    }
}
