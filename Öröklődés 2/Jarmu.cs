using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Öröklődés_2
{
    //Ősosztály - alaposztály
    internal class Jarmu
    {
        public string Marka { get; set; }
        public int Sebesseg { get; set; }

        public Jarmu(string marka, int sebesseg)
        {
            Marka = marka;
            Sebesseg = sebesseg;
        }

        public virtual void Kozlekedik()
        {
            Console.WriteLine($"{Marka} {Sebesseg} km/h-val közlekedik");
        }
    }
}
