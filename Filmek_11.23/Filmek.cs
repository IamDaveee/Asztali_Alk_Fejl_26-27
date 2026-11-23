using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmek_11._23
{
    abstract class Filmek
    {
        string Cim { get; set; }
        string Rendezo { get; set; }
        public int Hossz { get; set; }

        double ertekeles;

        abstract public int Korhatar { get; }

        public double Ertekeles
        {
            get => ertekeles;
            set => ertekeles = value < 0.0 || value > 10.0 ? throw new Exception("Az értékelésnek 0 és 10 között kell lennie") : value;
        }

        protected Filmek(string cim, string rendezo, int hossz, double ertekeles)
        {
            Cim = cim;
            Rendezo = rendezo;
            Hossz = hossz;
            Ertekeles = ertekeles;
        }

        abstract public void Veites();

        public virtual string FilmAdatok()
        {
            return $"Cím: {Cim}, Rendező: {Rendezo}, Film hossza: {Hossz}, Korhatár: {Korhatar}, Értékelés: {Ertekeles}.\n";
        }
    }
}
