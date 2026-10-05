using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Öröklődés_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
			try
			{
                Olvasmany olv1 = new Olvasmany("Minta olvsmány", "Minta Kálmás", 2025);
                olv1.Kiir();
                Console.WriteLine();
                Olvasmany olv2 = new Olvasmany("Minta olvsmány", "Minta Kálmás");
                olv2.Kiir();
                Console.WriteLine();

                Konyv k1 = new Konyv("Légikisasszonyok", "Bauer Barbara", 268);
                k1.Kiir();
                Console.WriteLine();
                Konyv k2 = new Konyv("A könyv címe", "Farkas György", 300);
                k2.Kiir();
                Console.WriteLine();

                //16.
                Magazin mg1 = new Magazin(" Gramofon magazin", "Bencsik Gyula", 2020, 5, "történelem");
                mg1.Kiir();
                Console.WriteLine();
                Magazin mg2 = new Magazin("Figyelő magazin", "Mong Attila", 1, "politika");
                mg2.Kiir();
                Console.WriteLine();
            }
			catch (Exception ex)
			{
                Console.WriteLine(ex.Message);
			}
            finally
            {
                Console.WriteLine("Program vége");
            }
        }
    }
}
