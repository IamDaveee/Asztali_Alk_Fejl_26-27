using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Öröklődés_2
{
    internal class Bicikli:Jarmu
    {
        public bool VanCsengo { get; set; }
        public Bicikli(string marka, int sebesseg, bool csengo):base(marka, sebesseg)
        {
            VanCsengo = csengo;
        }

        public override void Kozlekedik()
        {
            base.Kozlekedik();
            Console.WriteLine(VanCsengo? "Van csengője." : "Nincs csengője.");
        }
    }
}
