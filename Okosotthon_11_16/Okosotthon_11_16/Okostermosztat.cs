using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyak20261116Projekt
{
    internal class Okostermosztat:Okoseszkoz
    {
        double MertH { get; set; }
        double celH;

        public double CelH
        {
            get => celH;
            set
            {
                if (value<10||value>35)
                {
                    throw new Exception("Hiba! A célhőmérsékletnek 10 és 35 között lennie");

                }
                else
                {
                    celH = value;
                }

            }
        
        }
        public Okostermosztat(string tipus, int id, bool bekapcsolt, int fogyasztas, double MertH, double celH) : base(tipus, id, bekapcsolt, fogyasztas)
        {
            CelH = celH;
        }

        public override string AktualE()
        {
           
            if (Bekapcsolt==false||CelH==MertH)
            {
                Fogyasztas = 10/4;
            }
            else
            {
                Fogyasztas = Fogyasztas;
            }

            return $"{Fogyasztas}W";
        
        }
        public override string Diag()
        {
            string mod = "";
            if (CelH==MertH)
            {
                mod = "Hőntartás";

            }
            else
            {
                if (CelH>MertH)
                {
                    mod = "Fűtés";
                }
                else
                {
                    if (CelH<MertH)
                    {
                        mod = "Hűtés";
                    }
                    else
                    {
                        mod = "Készenlét";
                    }
                }
            }
            return $"Mért hőmérséklet: {MertH}, Célhőmérséklet{CelH} Fogíasztása: {AktualE()}, Aktuális üzemmódja: {mod}";
        }
    }
}
