using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otthoni_11._08
{
    internal class VegetarianusRecept : Recept
    {
        int kaloria;

        public int Kaloria
        {
            get => kaloria;
            set => kaloria = value < 0 ? throw new Exception("A kalóriatartalom nem lehet negatív!") : value;
        }

        public VegetarianusRecept(string nev, List<string> osszetevetok, int elkeszitesiIdo, DateTime letrehozasiIdo ,int kaloria) : base(nev, osszetevetok, elkeszitesiIdo, letrehozasiIdo)
        {
            Kaloria = kaloria;
        }

        public override string AllergenekEllenorzese()
        {
            return base.AllergenekEllenorzese() + $"Kalóriatartalma: {Kaloria} kcal";
        }

        public int TapErtekSzamitas()
        {
            return (Kaloria / 2000) * 100;
        }
    }
}
