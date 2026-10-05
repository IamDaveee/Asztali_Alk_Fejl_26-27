using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Öröklődés_4
{
    internal class Auto:Jarmu
    {
        int ajtokSzama;

        public int AjtokSzama
        {
            get => ajtokSzama;
            set => ajtokSzama = value < 2 ? 4 : value;
        }

        public Auto(string marka, string tipus, int gyartasiEv, int ajtokSzama) : base(marka, tipus, gyartasiEv)
        {
            AjtokSzama = ajtokSzama;
        }
        public Auto(string marka, string tipus, int ajtokSzama) : base(marka, tipus)
        {
            AjtokSzama = ajtokSzama;
        }

        public override string Megjelenit()
        {
            return base.Megjelenit() + $"\nAz ajtók száma: {AjtokSzama}";
        }
    }
}
