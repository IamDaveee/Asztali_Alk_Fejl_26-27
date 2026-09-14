using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diáktanya
{
    internal class AjtoLog
    {
        public string nev, azon;
        public int beOra,bePerc, kiOra, kiPerc;
        public int beOraPerc, kiOraPerc;

        public AjtoLog(string sor)
        {
            string[] egysor = sor.Split(';');
            nev = egysor[0];
            azon = egysor[1];
            beOra = Convert.ToInt32(egysor[2]);
            bePerc = Convert.ToInt32(egysor[3]);
            kiOra = Convert.ToInt32(egysor[4]);
            kiPerc = Convert.ToInt32(egysor[5]);
            beOraPerc = beOra * 60 + bePerc;
            kiOraPerc = kiOra * 60 + kiPerc;
        }
    }
}
