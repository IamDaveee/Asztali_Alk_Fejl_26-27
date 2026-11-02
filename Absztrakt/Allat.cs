using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Absztrakt
{
    abstract class Allat
    {
        string nev;
        int kor;

        public string Nev
        {
            get => nev;
            set => nev = string.IsNullOrEmpty(value) ? throw new Exception("Hiba! A név nem lehet üres") : value;
        }
        int Kor
        {
            get => kor;
            set=>kor = value < 0 ? throw new Exception("Hiba! A kor nem lehet negatív") : value;
        }

        protected Allat(string nev, int kor)
        {
            Nev = nev;
            Kor = kor;
        }

        //absztakt metódusok - gyerek osztálynak kell megvalósítani
        public abstract void HangotAd();
        public abstract void Eszik();
    }
}
