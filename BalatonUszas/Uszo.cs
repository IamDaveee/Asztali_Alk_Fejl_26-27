using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalatonUszas
{
    internal class Uszo
    {
        public int futam;
        public string ido, nev, klub;
        public string teljesKlub;

        public Uszo(string sor)
        {
            string[] egysor=sor.Split(';');
            futam = Convert.ToInt32(egysor[0]);
            ido = egysor[1];
            nev = egysor[2] + " " + egysor[3];
            klub = egysor[4];
            switch (klub)
            {
                case "VV":
                    {
                        teljesKlub = "Vízi Vágta";
                    }
                    break;
                case "BB":
                    {
                        teljesKlub = "Balatoni Bálnák";
                    }
                    break;
                case "HSE":
                    {
                        teljesKlub = "Hullámtörők SE";
                    }
                    break;
                case "DÚ":
                    {
                        teljesKlub = "Delfin Úszóiskola";
                    }
                    break;
                default:
                    {
                        teljesKlub = "Hobbiúszó";
                    }
                    break;
            }
        }
    }
}
