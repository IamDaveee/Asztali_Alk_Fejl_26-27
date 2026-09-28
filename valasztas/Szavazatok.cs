using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace valasztas
{
    internal class Szavazatok
    {
        public int sorszam, szavazatzok;
        public string nev, part, teljesPart;

        public Szavazatok(string sor)
        {
            string[] egysor = sor.Split(' ');
            sorszam = Convert.ToInt32(egysor[0]);
            szavazatzok = Convert.ToInt32(egysor[1]);
            nev = egysor[2] + " " + egysor[3];
            part = egysor[4];

            switch (part)
            {
                case "GYEP":
                    {
                        teljesPart = "Gyümölcsevők Pártja";
                        break;
                    }
                case "HEP":
                    {
                        teljesPart = "Húsevők Pártja";
                        break;
                    }
                case "TISZ":
                    {
                        teljesPart = "Tejivók Szövetsége";
                        break;
                    }
                case "ZEP":
                    {
                        teljesPart = " Zöldségevők Pártja";
                        break;
                    }


                default:
                    teljesPart = "Független jelöltek";
                    break;
            }
        }
    }
}
