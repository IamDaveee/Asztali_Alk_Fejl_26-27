using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okosotthon
{
    internal class OkosTermosztát:Okoseszközök
    {
        double celHo;

        double AktualHo { get; set; }
        public override double Teljesitmeny { get; set; }

        public override bool Bekapcsolva { get; set; }

        public double Celho
        {
            get => celHo;
            set=> celHo = value<10.0 || value >35.0? throw new Exception("A hőmérséklet csak 10.0 és35.0 °C között lehet"):value;
        }

        public OkosTermosztát(string nev, int azonosito, double teljesitmeny, double celHo, double aktualHo) : base(nev, azonosito, teljesitmeny)
        {
            Celho = celHo;
            AktualHo = aktualHo;
            if (Celho != AktualHo)
            {
                Bekapcsolva = true;
            }
            if (!Bekapcsolva || Celho==AktualHo)
            {
                Teljesitmeny = 2.5;
            }
            else if (Bekapcsolva || Celho!=AktualHo)
            {
                Teljesitmeny = teljesitmeny;
            }
        }

        public string Modositas(double celHo)
        {
            try
            {
                Celho = celHo;
                if (Celho != AktualHo)
                {
                    Bekapcsolva = true;
                }
                if (!Bekapcsolva || Celho == AktualHo)
                {
                    Teljesitmeny = 2.5;
                }
                return $"{Diagnosztika()}";
            }
            catch (Exception ex)
            {
                return $"{ex.Message}";
            }
        } 

        public override string Aktualis()
        {
            return $"A termosztát aktuális fogyasztása: {Teljesitmeny}W.";
        }

        public override string Diagnosztika()
        {
            if (Bekapcsolva && Celho>AktualHo)
            {
                return Kiir() + $", Mért hő: {AktualHo}°C, Kívánt hő: {Celho}°C, Aktuális fogyasztás: {Teljesitmeny}W, Üzemmód: Fűtés";
            }
            else if (Bekapcsolva && Celho < AktualHo)
            {
                return Kiir() + $", Mért hő: {AktualHo}°C, Kívánt hő: {Celho}°C, Aktuális fogyasztás: {Teljesitmeny}W, Üzemmód: Hűtés";
            }
            else if (Bekapcsolva && Celho == AktualHo)
            {
                return Kiir() + $", Mért hő: {AktualHo}°C, Kívánt hő: {Celho}°C, Aktuális fogyasztás: {Teljesitmeny}W, Üzemmód: Hőntartás";
            }
            else
            {
                return Kiir() + $", Mért hő: {AktualHo}°C, Kívánt hő: {Celho}°C, Aktuális fogyasztás: {Teljesitmeny}W, Üzemmód: Készenlét";
            }
        }
    }
}
