using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarmuKezeles
{
    abstract class Jarmu
    {
        string tipus;
        int sebesseg;

        double Uzemanyag { get; set; }

        public abstract double Fogyasztas { get; }
        public abstract double Inditas { get; }

        public string Tipus
        {
            get=> tipus;

            set => tipus = string.IsNullOrEmpty(value) || value == "ismeretlen" ? throw new Exception("A típus üres vagy ismeretlen érték!") : value;
        }

        public int Sebesseg
        {
            get => sebesseg;
            set => sebesseg = value < 0 || value > 250 ? throw new Exception("A sebesség nem lehet negatív, vagy nagyobb mint 250 kph") : value;
        }

        protected Jarmu(string tipus, int sebesseg, double uzemanyag)
        {
            Tipus = tipus;
            Sebesseg = sebesseg;
            Uzemanyag = uzemanyag;
        }

        public abstract double FogyasztasMerteke();

        public void Utazas(double megtettKm)
        {
            double fogyasztas = FogyasztasMerteke() * megtettKm / 100;
            if (Uzemanyag-fogyasztas < 0)
            {
                Uzemanyag = 0;
                throw new Exception("Az üzemanyag elfogyott");
            }
            else
            {
                Uzemanyag = Uzemanyag - fogyasztas;
            }
        }

        public abstract bool Indit();

        public override string ToString()
        {
            return $"Típusa: {Tipus}, Sebessége: {Sebesseg}, Üzemanyag: {Uzemanyag}l";
        }
    }
}
