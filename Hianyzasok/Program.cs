using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Hianyzasok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Napok> adatok = new List<Napok>();
            File.ReadAllLines("szeptember.csv", Encoding.Default).Skip(1).ToList().ForEach(x => adatok.Add(new Napok(x)));

            Console.WriteLine($"2. feladat:\n\tÖsszes múlasztott órák száma: {adatok.Sum(x=>x.orakSzama)}");

            Console.WriteLine("3. feladat:");
            Console.WriteLine("\tKérem adjon meg egy napot: ");
            int nap = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\tTanuló neve: ");
            string nev = Console.ReadLine();

            Console.WriteLine(adatok.Any(x=>x.nev==nev)?"A tanuló hiányzott szeptemberben":"A tanuló nemhiányzott szeptemberben");

            Console.WriteLine($"5. feladat: Hiányzók 2017.09.{nap}-n:");

            if (adatok.Any(x=>x.elsoNap==nap))
            {
                adatok.Where(x => x.elsoNap == nap).OrderBy(x => x.osztaly).ToList().ForEach(x => Console.WriteLine($"{x.nev} ({x.osztaly})"));
            }
            else
            {
                Console.WriteLine("Nem volt hiányzó");
            }

            StreamWriter sw = new StreamWriter("osszesites.csv");
            adatok.OrderBy(x => x.osztaly).GroupBy(x => x.osztaly).ToList().ForEach(x=>sw.WriteLine($"{x.Key};{x.Sum(y=>y.orakSzama)}"));
            sw.Close();
        }
    }
}
