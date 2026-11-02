using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Absztrakt
{
    abstract class Jarmu
    {
        public string Marka { get; set; }
        public string Modell { get; set; }
        public int NapiDij { get; set; }

        //absztarkt jellemző
        public abstract string Rendszam { get; }

        protected Jarmu(string marka, string modell, int napiDij)
        {
            Marka = marka;
            Modell = modell;
            NapiDij = napiDij;
        }

        public abstract int BerletiDij(int napok);

        public override string ToString()
        {
            return $"A {Marka} {Modell} jármű napidíja: {NapiDij} Ft.";
        }
    }
}
