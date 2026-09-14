using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bringasok
{
    internal class Versenyzo
    {
        public int szakasz;
        public string ido, nev, csapat;
        public string csapatTeljes;

        public Versenyzo(string sor)
        {
            string[] egysor = sor.Split(';');
            szakasz = Convert.ToInt32(egysor[0]);
            ido = egysor[1];
            nev = egysor[2] + " " + egysor[3];
            csapat = egysor[4];

            switch (csapat)
            {
                case "PH":
                    {
                        csapatTeljes = "Pedál Huszárok";
                    }
                    break;
                case "VK":
                    {
                        csapatTeljes = "Viharsarki Küllők";
                    }
                    break;
                case "AB":
                    {
                        csapatTeljes = "Aszfaltbetyárok";
                    }
                    break;
                case "LSE":
                    {
                        csapatTeljes = "Láncreakció SE";
                    }
                    break;
                default:
                    {
                        csapatTeljes = "Amatőr versenyzők";
                    }
                    break;
            }
        }
    }
}
