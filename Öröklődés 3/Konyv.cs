using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Öröklődés_3
{
    internal class Konyv:Olvasmany
    {
        int oldalakSzama;

        public int OldalakSzama
        {
            get => oldalakSzama;
            set => oldalakSzama = value <= 0 ? 1 : value;
        }

        public Konyv(string cim, string szerzo, int kiadasEve, int oldalakSzama) : base(cim, szerzo, kiadasEve)
        {
            OldalakSzama = oldalakSzama;
        }

        public Konyv(string cim, string szerzo, int oldalakSzama):base(cim, szerzo)
        {
            OldalakSzama = oldalakSzama;
        }

        public override void Kiir()
        {
            base.Kiir();
            Console.WriteLine($"Oldalak száma: {OldalakSzama}");
        }
    }
}
