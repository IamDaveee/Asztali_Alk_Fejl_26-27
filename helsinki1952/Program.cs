using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace helsinki1952
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Helsinki> adatok = new List<Helsinki>();

            File.ReadAllLines("helsinki.txt").ToList().ForEach(x => adatok.Add(new Helsinki(x)));

            Console.WriteLine($"3. feladat:\n\tPontszerző helyezések száma: {adatok.Count}");
            Console.WriteLine();

            Console.WriteLine("4.feladat: ");
            adatok.Where(x => x.erem != "-").GroupBy(x => x.erem).ToList().ForEach(x=> Console.WriteLine($"\t{x.Key}: {x.Count()}"));
            Console.WriteLine($"\tÖsszesen: {adatok.Where(x => x.erem != "-").Count()}");
            Console.WriteLine();

            Console.WriteLine($"5. feladat:\nOlimpiai pontok száma: {adatok.Sum(x=>x.pont)}");
            Console.WriteLine();

            int uszas = adatok.Where(x => x.versenyszam == "uszas" && x.erem!="-").Count();
            int torna = adatok.Where(x => x.versenyszam == "torna" && x.erem!="-").Count();
            if (uszas==torna)
            {
                Console.WriteLine("Egyenlő volt az érmek száma");
            }
            else
            {
                Console.WriteLine(uszas>torna?"Úszás sportágban szereztek több érmet":"Torna sportágban szereztektöbb érmet");
            }
            Console.WriteLine();

            StreamWriter sw = new StreamWriter("helsinki2.txt", false, Encoding.Default);
            foreach (var item in adatok)
            {
                if (item.sportág=="kajakkenu")
                {
                    sw.WriteLine($"{item.helyezes} {item.sportolokSzama} {item.pont} kajak-kenu {item.versenyszam}");
                }
                else
                {
                    sw.WriteLine($"{item.helyezes} {item.sportolokSzama} {item.pont} {item.sportág} {item.versenyszam}");
                }
            }
            sw.Close();

            Console.WriteLine("8. feladat:");
            var legtöbb = adatok.OrderByDescending(x => x.sportolokSzama).First();
            Console.WriteLine($"\tHelyezés: {legtöbb.helyezes}\n\tSportág: {legtöbb.sportág}\n\tVersenyszám: {legtöbb.versenyszam}\n\tSportolók száma: {legtöbb.sportolokSzama}");
        }
    }
}
