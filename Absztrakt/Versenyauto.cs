using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Absztrakt
{
    internal class Versenyauto:Jarmu
    {
        public int Loero { get; set; }
        string rsz;
        public override string Rendszam => rsz;

        public Versenyauto(string marka, string modell, int napiDij, int loero, string rendszam):base(marka, modell, napiDij)
        {
            rsz = rendszam;
            Loero = loero;
        }

        public override int BerletiDij(int napok)
        {
            return napok >= 5 ? napok*NapiDij-10000 : napok*NapiDij;
        }

        public override string ToString()
        {
            return base.ToString() + $"Rendszáma: {Rendszam}, Lóerő: {Loero}";
        }
    }
}
