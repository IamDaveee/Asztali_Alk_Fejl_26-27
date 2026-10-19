using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Receptek
{
    internal class VegetarianusRecept:Recept
    {
        int kaloria;

        public int Kaloria
        {
            get => kaloria;
            set => kaloria = value < 1 ? throw new Exception("Hiba! A kalória nem lehet 0 vagy negatív") : value;
        }
        public VegetarianusRecept(string nev, List<string> osszetevok, int elkeszitesiIdo, DateTime letrehozasIdeje, int kaloria) : base(nev, osszetevok, elkeszitesiIdo, letrehozasIdeje)
        {
            Kaloria = kaloria;
        }
        public VegetarianusRecept(string nev, List<string> osszetevok, int kaloria) :base(nev, osszetevok)
        {
            Kaloria = kaloria;
        }

        public override string AllergenekEllenorzese()
        {
            return base.AllergenekEllenorzese() + $"Kalória tartalom: {Kaloria}";
        }

        public int TapErtekSzamitas()
        {
            return (Kaloria/2000)*100;
        }
    }
}
