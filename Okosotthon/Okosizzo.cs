using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okosotthon
{
    internal class Okosizzo:Okoseszközök
    {
        int fenyerosseg;

        public int Fenyerosseg
        {
            get => fenyerosseg;
            set => fenyerosseg = value < 0 || value > 100 ? throw new Exception("nem lehet kisebb mint 0, vagy nagyobb mint 100.") : value;
        }
        public override bool Bekapcsolva { get; set; }
        public override double Teljesitmeny { get; set; }

        public Okosizzo(string nev, int azonosito, double teljesitmeny, int fenyerosseg) : base(nev, azonosito, teljesitmeny)
        {
            Fenyerosseg = fenyerosseg;
        }

        public string Modosit(int ertek)
        {
            try
            {
                Fenyerosseg = ertek;
                return $"A fényerősség új értéke: {Fenyerosseg}";
            }
            catch (Exception ex)
            {
                return $"{ex.Message}";
            }
        }
        public override string Aktualis()
        {
            return $"Energiafogyasztás: {Fenyerosseg}W.";
        }
        public override string Diagnosztika()
        {
            return Kiir() + ", " + $"Diagnosztika: Az aktuális fényerősség {Fenyerosseg}%, az éppen mért wattfogyasztás {Fenyerosseg}W.";
        }
    }
}
