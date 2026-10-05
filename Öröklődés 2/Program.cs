using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Öröklődés_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Hozzunk létre járművet
            Jarmu jarmu = new Jarmu("Általános Jármű", 100);
            jarmu.Kozlekedik();
            Console.WriteLine();

            //2. Auto osztály példánya
            Auto auto = new Auto("Porsche", 200, 2);
            auto.Kozlekedik();
            Console.WriteLine();

            //3. Bicikli példánya
            Bicikli bicikli = new Bicikli("Csepel", 60, true);
            bicikli.Kozlekedik();
        }
    }
}
