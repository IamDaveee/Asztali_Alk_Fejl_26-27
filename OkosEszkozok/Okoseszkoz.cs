using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkosEszkozok
{
    internal class Okoseszkoz
    {
        string nev, allapot;
        int fogyasztas;
        DateTime letrehozasIdeje;

        public string Nev
        {
            get => nev;
            set=>nev=string.IsNullOrEmpty(value) ? throw new Exception("Hiba! A név nemlehet üres") : value;
        }
        public string Allapot
        {
            get => allapot;
            set
            {
                if (value=="bekapcsolva" || value=="kikapcsolva")
                {
                    allapot = value;
                }
                else
                {
                    throw new Exception("Az állapot értékei: bekapcsolva/kikapcsolva lehet!");
                }

                if (value== "kikapcsolva" && Fogyasztas!=0)
                {
                    throw new Exception("Hiba! Kikapcsolt állapotban a fogyasztásnak nullának kell lennie!");
                }
            }
        }
        public int Fogyasztas
        {
            get => fogyasztas;
            set
            {
                if (value<0)
                {
                    throw new Exception("Hiba! A fogyasztás nem lehet negatív!");
                }
                if (Allapot=="kikapcsolva")
                {
                    fogyasztas = 0;
                }
                if (Allapot=="kikapcsolva" && Fogyasztas>0)
                {
                    throw new Exception("Hiba! Kikapcsolt állapotban a fogyasztásnak nullának kell lennie!");
                }
                fogyasztas = value;
            }
        }
        public DateTime LetrehozasIdeje
        {
            get => letrehozasIdeje;
            set => letrehozasIdeje = value < new DateTime(1990, 01, 01) || value > DateTime.Now ? throw new Exception("Hiba! A dátumnak 1990.01.01 és azaktuális dátum között kell lennie") : value;
        }
    }
}
