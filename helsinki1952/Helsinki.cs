using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helsinki1952
{
    internal class Helsinki
    {
        public int helyezes, sportolokSzama, pont;
        public string sportág, versenyszam, erem;

        public Helsinki(string sor)
        {
            string[] egysor = sor.Split(' ');
            helyezes = Convert.ToInt32(egysor[0]);
            sportolokSzama = Convert.ToInt32(egysor[1]);
            sportág = egysor[2];
            versenyszam = egysor[3];

            switch (helyezes)
            {
                case 1:
                    pont = 7;
                    erem = "Arany";
                    break;
                case 2:
                    pont = 5;
                    erem = "Ezüst";
                    break;
                case 3:
                    pont = 4;
                    erem = "Bronz";
                    break;
                case 4:
                    pont = 3;
                    erem = "-";
                    break;
                case 5:
                    pont = 2;
                    erem = "-";
                    break;
                case 6:
                    pont = 1;
                    erem = "-";
                    break;
            }
        }
    }
}
