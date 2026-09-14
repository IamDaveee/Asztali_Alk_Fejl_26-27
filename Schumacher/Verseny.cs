using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schumacher
{
    internal class Verseny
    {
        public string date, grandprix, team, status;
        public int position, laps, points;

        public Verseny(string sor)
        {
            string[] egysor = sor.Split(';');
            date = egysor[0];
            grandprix = egysor[1];
            position = Convert.ToInt32(egysor[2]);
            laps = Convert.ToInt32(egysor[3]);
            points = Convert.ToInt32(egysor[4]);
            team = egysor[5];
            status = egysor[6];
        }
    }
}
