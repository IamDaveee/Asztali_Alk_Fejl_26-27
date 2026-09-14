using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace bringasok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Versenyzo> adatok = new List<Versenyzo>();
            File.ReadAllLines("eredmenyek.csv").Skip(1).ToList().ForEach(x => adatok.Add(new Versenyzo(x)));

            Console.WriteLine($"5. feladat: A BringaParádé során összesen {adatok.Count} versenyző ért célba.");
            Console.WriteLine();

            Console.WriteLine("6. feladat: Kérem egy versenyző nevét: ");
            string nev = Console.ReadLine();
            if (adatok.Any(x => x.nev == nev))
            {
                adatok.Where(x => x.nev == nev).ToList().ForEach(x => Console.WriteLine($"{x.nev} ideje: {x.ido}"));
            }
            else
            {
                Console.WriteLine("Nincs ilyen nevű versenyző a listában.");
            }
            Console.WriteLine();

            Console.WriteLine($"7. feladat: A versenyen {adatok.Count} sportoló, a nevezők {Math.Round(adatok.Count/1850.0*100 , 2)}%-a vett részt");
            Console.WriteLine();

            Console.WriteLine("8. feladat:");
            adatok.GroupBy(x=>x.csapatTeljes).ToList().ForEach(x=> Console.WriteLine($"{x.Key} - {x.Count()} fő"));
            Console.WriteLine();

            Console.WriteLine("9. feladat:");
            string legjobb = adatok.OrderBy(x => x.ido).First().ido;
            adatok.Where(x => x.ido == legjobb).ToList().ForEach(x => Console.WriteLine($"A leggyorsabb ({x.ido}) {x.nev} volt ({x.csapatTeljes})."));
            Console.WriteLine();

            StreamWriter sw = new StreamWriter("szakaszok.txt");
            adatok.OrderBy(x => x.szakasz).GroupBy(x => x.szakasz).ToList().ForEach(x => sw.WriteLine($"{x.Key}. szakasz - célba érkezők: {x.Count()} fő"));
            sw.Close();
            Console.WriteLine("10. feladat: Az adatok fájlba írása megtörtént.");
        }
    }
}
