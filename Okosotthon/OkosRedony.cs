using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okosotthon
{
    internal class OkosRedony:Okoseszközök
    {
        int lehuzva;

        public override bool Bekapcsolva { get; set; }
        public override double Teljesitmeny { get; set; }
        public int Lehuzva
        {
            get => lehuzva;
            set=>lehuzva = value < 0 || value > 100 ? throw new Exception("nem lehet kisebb mint 0, vagy nagyobb mint 100.") : value;
        }

        public OkosRedony(string nev, int azonosito, double teljesitmeny) : base(nev, azonosito, teljesitmeny)
        {
            Lehuzva = 0;
            Bekapcsolva = true;
        }

        public void Mozgatas(int ertek)
        {
            if (ertek<0 || ertek>100)
            {
                
            }
            else
            {
                Lehuzva = ertek;
            }
        }

        public override string Kapcsolo()
        {
            Bekapcsolva = !Bekapcsolva;
            if (Bekapcsolva)
            {
                Lehuzva = 0;
                return $"A redőny nappali módban van (bekapcsolva, {Lehuzva}% lehúzva)";
            }
            else
            {
                Lehuzva = 100;
                return $"A redőny éjszakai módban van (kikapcsolva, {Lehuzva}% lehúzva)";
            }
        }

        public override string Diagnosztika()
        {
            return Kiir() + $", A redőny lehúzottsági szintje: {Lehuzva}%, nyugalmi fogyasztása: 1.2";
        }

        public override string Aktualis()
        {
            return $"Mozgásban: {Teljesitmeny}, nyugalmi helyzetben: 1.2";
        }
    }
}
