using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VizibicikliKolcsonzo
{
    internal class Kolcsonzes
    {
        public string nev, jazon;
        public int elvitelOra, elvitelPerc, visszaOra, visszaPerc;
        public int elvOraPerc, visszaOraPerc;

        public Kolcsonzes(string nev, string jazon, int elvitelOra, int elvitelPerc, int visszaOra, int visszaPerc)
        {
            this.nev = nev;
            this.jazon = jazon;
            this.elvitelOra = elvitelOra;
            this.elvitelPerc = elvitelPerc;
            this.visszaOra = visszaOra;
            this.visszaPerc = visszaPerc;
        }

        public Kolcsonzes(string sor)
        {
            string[] adatok = sor.Split(';');
            nev= adatok[0];
            jazon= adatok[1];
            elvitelOra= Convert.ToInt32(adatok[2]);
            elvitelPerc= Convert.ToInt32(adatok[3]);
            visszaOra= Convert.ToInt32(adatok[4]);
            visszaPerc = Convert.ToInt32(adatok[5]);
            elvOraPerc = elvitelOra * 60 + elvitelPerc;
            visszaOraPerc = visszaOra * 60 + visszaPerc;
        }

        //függvény átalakításra
        public int Percben(int ora,int perc)
        {
            return ora * 60 + perc;
        }
    }
}
