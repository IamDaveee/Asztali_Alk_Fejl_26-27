using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozat_balázsDávid_2026_09_28
{
    internal class Dal
    {
        public string dalcim, stilus;
        public int szinpadSorszam, szavazatok, zsuriHelyezes, szakmaiPont;

        public Dal(string sor)
        {
            string[] egysor = sor.Split(';');
            dalcim = egysor[0];
            szinpadSorszam = Convert.ToInt32(egysor[1]);
            stilus = egysor[2];
            szavazatok= Convert.ToInt32(egysor[3]);
            zsuriHelyezes= Convert.ToInt32(egysor[4]);

            switch (zsuriHelyezes)
            {
                case 1:
                    {
                        szakmaiPont = 100;
                        break;
                    }
                case 2:
                    {
                        szakmaiPont = 80;
                        break;
                    }
                case 3:
                    {
                        szakmaiPont = 60;
                        break;
                    }
                case 4:
                    {
                        szakmaiPont = 40;
                        break;
                    }
                case 5:
                    {
                        szakmaiPont = 20;
                        break;
                    }
                case 6:
                    {
                        szakmaiPont = 10;
                        break;
                    }

                default:
                    szakmaiPont = 0;
                    break;
            }
        }
    }
}
