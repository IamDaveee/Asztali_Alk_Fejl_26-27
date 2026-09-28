using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace valasztas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Szavazatok> adatok = new List<Szavazatok>();
            File.ReadAllLines("szavazatok.txt").ToList().ForEach(x => adatok.Add(new Szavazatok(x)));

            Console.WriteLine($"A helyhatósági választáson {adatok.Count} képviselőjelölt indult. ");

            Console.WriteLine("Kérek egy nevet: ");
            string nev = Console.ReadLine();

            if (adatok.Any(x=>x.nev==nev))
            {
                adatok.Where(x => x.nev == nev).ToList().ForEach(x => Console.WriteLine($"{x.nev} - {x.szavazatzok}"));
            }
            else
            {
                Console.WriteLine("Ilyen nevű képviselőjelölt nem szerepel a nyilvántartásban");
            }

            Console.WriteLine($"A választáson {adatok.Sum(x=>x.szavazatzok)} állampolgár, a jogosultak {Math.Round(adatok.Sum(x=>x.szavazatzok/12345.0),2)*100}%-a vett részt. ");

            adatok.GroupBy(x => x.teljesPart).ToList().ForEach(x => Console.WriteLine($"{x.Key} - {x.Sum(y=>y.szavazatzok)}"));

            Console.WriteLine($"{adatok.OrderByDescending(x=>x.szavazatzok).First().nev} - {adatok.OrderByDescending(x => x.szavazatzok).First().szavazatzok} - {adatok.OrderByDescending(x => x.szavazatzok).First().part}");

            StreamWriter sw = new StreamWriter("statisztika.txt");
            adatok.GroupBy(x => x.sorszam).OrderBy(x => x.Key).ToList().ForEach(x => sw.WriteLine($"{x.Key}. kerület - {x.Sum(y=>y.szavazatzok)}"));
            sw.Close();
        }
    }
}
