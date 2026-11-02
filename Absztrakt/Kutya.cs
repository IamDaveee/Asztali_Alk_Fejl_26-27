using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Absztrakt
{
    internal class Kutya:Allat
    {
        public string Gazda { get; set; }
        public Kutya(string nev, int kor, string gazda):base(nev, kor)
        {
            Gazda = gazda;
        }

        public override void HangotAd()
        {
            Console.WriteLine("Vau-Vau");
        }
        public override void Eszik()
        {
            Console.WriteLine("A kutya gyorsan eszik");
        }
    }
}
