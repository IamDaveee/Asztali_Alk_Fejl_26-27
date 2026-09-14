using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BalatonUszas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Uszo> adatok = new List<Uszo>();
            File.ReadAllLines("uszok.txt").ToList().ForEach(x=>adatok.Add(new Uszo(x)));

            Console.WriteLine($"5. feladat: {adatok.Count}");

            Console.WriteLine("Kérem egy úszó nevét: ");
            string nev = Console.ReadLine();

            if (adatok.Any(x=>x.nev==nev))
            {
                Console.WriteLine($"{nev} ideje: {adatok.Where(x=>x.nev==nev).First().ido}");
                Console.WriteLine($"{nev} ideje: {adatok.Find(x=>x.nev==nev).ido}");
            }
            else
            {
                Console.WriteLine("Nincs ilyen nevű versenyző.");
            }

            Console.WriteLine($"A versenyen {adatok.Count} sportoló, a nevezettek {Math.Round(adatok.Count/3200.0*100 , 2)}% százaléka vett részt");

            adatok.GroupBy(x => x.teljesKlub).ToList().ForEach(x => Console.WriteLine($"{x.Key} - {x.Count()}"));

            var leglassabb = adatok.OrderBy(x => x.ido).Last();
            Console.WriteLine($"A leglassabb ({leglassabb.ido}) {leglassabb.nev} volt ({leglassabb.teljesKlub})");

            StreamWriter sw = new StreamWriter("futamok.txt");
            adatok.OrderBy(x => x.futam).GroupBy(x => x.futam).ToList().ForEach(x => sw.WriteLine($"{x.Key}.szakasz - célba érkezők: {x.Count()}"));
            sw.Close();
        }
    }
}
