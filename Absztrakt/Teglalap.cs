using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Absztrakt
{
    internal class Teglalap:Alakzat
    {
        public double Aoldal { get; set; }
        public double Boldal { get; set; }

        public Teglalap(string szin, double aoldal, double boldal) : base(szin)
        {
            Aoldal = aoldal;
            Boldal = boldal;
        }

        public override string ToString()
        {
            return base.ToString() + $"A téglalap oldalai: {Aoldal}, {Boldal}";
        }

        public override double Terulet()
        {
            return Aoldal * Boldal;
        }
    }
}
