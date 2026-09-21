using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nobel
{
    internal class Nyertesek
    {
        public int evszam;
        public string tipus, nev;

        public Nyertesek(string sor)
        {
            string[] egysor = sor.Split(';');
            evszam =Convert.ToInt32(egysor[0]);
            tipus = egysor[1];
            
            nev = egysor[2] + " " + egysor[3];
        }
    }
}
