using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Nobel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Nyertesek> adatok = new List<Nyertesek>();

            File.ReadAllLines("nobel.csv").Skip(1).ToList().ForEach(x => adatok.Add(new Nyertesek(x)));

            Console.WriteLine($"4. feladat: {adatok.Find(x=>x.nev== "Arthur B. McDonald").tipus}");

            Console.WriteLine($"5. feladat: 2017-benirodalmi Nóbel díjat kapott: \n\t{adatok.Find(x=>x.evszam==2017 && x.tipus=="irodalmi").nev}");

            Console.WriteLine("6. feladat: Béke Nóbel díjasok 1990-től napjainkig:");
            adatok.Where(x => x.evszam >= 1990).Where(x => x.tipus == "béke").OrderByDescending(x=>x.evszam).ToList().ForEach(x=> Console.WriteLine($"\t{x.evszam}: {x.nev}"));

            Console.WriteLine("7. feladat: A Curie család Nóbel díjasai:");
            adatok.Where(x => x.nev.Contains("Curie")).ToList().ForEach(x => Console.WriteLine($"\t{x.evszam}: {x.nev} ({x.tipus})"));

            Console.WriteLine("8. feladat: Nóbel díj statisztika:");
            adatok.GroupBy(x => x.tipus).ToList().ForEach(x=> Console.WriteLine($"\t{x.Key} - {x.Count()} db"));

            StreamWriter sw = new StreamWriter("orvosi.txt");
            adatok.Where(x => x.tipus == "orvosi").OrderBy(x=>x.evszam).ToList().ForEach(x=>sw.WriteLine($"{x.evszam},{x.tipus},{x.nev}"));
            sw.Close();
        }
    }
}
