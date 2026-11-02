using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Absztrakt
{
    internal class Auto:Jarmu
    {
        string rsz;
        public override string Rendszam
        {
            get => rsz;
        }

        public Auto(string marka, string modell, int napiDij, string rendszam):base(marka, modell, napiDij)
        {
            rsz = rendszam;
        }

        public override int BerletiDij(int napok)
        {
            return NapiDij * napok;
        }
        public override string ToString()
        {
            return base.ToString() + $"Az autó rendszáma: {Rendszam}";
        }
    }
}
