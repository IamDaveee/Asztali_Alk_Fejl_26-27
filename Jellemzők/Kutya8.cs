using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jellemzők
{
    internal class Kutya8
    {
        //statikus jellemzők
        public static int KutyakSzama{ get; private set; }
        public string Nev { get; }
        public Kutya8(string nev)
        {
            Nev = nev;
            KutyakSzama++;
        }
    }
}
