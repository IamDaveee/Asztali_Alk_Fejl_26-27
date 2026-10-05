using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Öröklődés_2
{
    //2. Auto osztaly, örökli a Jarmu osztályt
    internal class Auto:Jarmu
    {
        public int AjtokSzama { get; set; }

        public Auto(string marka, int sebesseg, int ajtokSzama) : base(marka, sebesseg)
        {
            AjtokSzama = ajtokSzama;
        }

        public override void Kozlekedik()
        {
            base.Kozlekedik();
            Console.WriteLine($"Az ajtók száma: {AjtokSzama}");
        }
    }
}
