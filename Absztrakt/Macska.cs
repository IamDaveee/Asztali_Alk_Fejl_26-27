using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Absztrakt
{
    internal class Macska:Allat
    {
        bool veszettE;
        public Macska(string nev, int kor, bool veszettE) : base(nev, kor)
        {
            this.veszettE = veszettE;
        }

        public override void Eszik()
        {
            Console.WriteLine("A macska nyammog");
        }
        public override void HangotAd()
        {
            Console.WriteLine("Miau-Miau Nigga");
        }
    }
}
