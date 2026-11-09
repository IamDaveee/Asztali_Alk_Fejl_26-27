using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarmuKezeles
{
    internal class SzemelyAuto : Jarmu
    {
        double fogyasztas, inditas;
        int ulesekSzama;

        public override double Fogyasztas
        {
            get => fogyasztas;
        }

        public override double Inditas
        {
            get => inditas;
        }

        public int UlesekSzama
        {
            get => ulesekSzama;
            set => ulesekSzama = value < 0 ? throw new Exception("Az ülések száma nem lehet negatív") : value;
        }

        public SzemelyAuto(string tipus, int sebesseg, double uzemanyag, double fogyasztas, double inditas, int ulesekSzama) : base(tipus, sebesseg, uzemanyag)
        {
            this.fogyasztas = fogyasztas;
            this.inditas = inditas;
            UlesekSzama = ulesekSzama;
        }

        public override double FogyasztasMerteke()
        {
            return Fogyasztas;
        }

        public override bool Indit()
        {
            if (true)
            {
                
            }
        }
    }
}
