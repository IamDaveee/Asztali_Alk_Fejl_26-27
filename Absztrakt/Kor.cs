using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Absztrakt
{
    internal class Kor:Alakzat
    {
        public double r;
        public Kor(string szin, double sugar):base(szin)
        {
            r = sugar;
        }

        public override double Terulet()
        {
            return Math.Pow(r, 2) * Math.PI;
        }

        public override string ToString()
        {
            return base.ToString() + $"Kör sugara: {r}";
        }
    }
}
