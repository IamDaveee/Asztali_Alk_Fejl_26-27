using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Dolgozat_balázsDávid_2026_09_28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Dal> adatok = new List<Dal>();
            File.ReadAllLines("dalok.txt").Skip(1).ToList().ForEach(x => adatok.Add(new Dal(x)));

            Console.WriteLine($"3. feladat: A fesztiválon elhangzott dalok száma: {adatok.Count} db");
            Console.WriteLine();

            Console.WriteLine($"4. feladat: Népszerű rockdalokszáma: {adatok.Where(x=>x.stilus=="Rock").Where(x=>x.szavazatok>=2500).Count()} db");
            Console.WriteLine();

            Console.WriteLine("5. feladat: Kérek egy dalt: ");
            string dal = Console.ReadLine();
            if (adatok.Any(x=>x.dalcim==dal))
            {
                Console.WriteLine("A dal elhangzik a fesztiválon.");
                adatok.Where(x => x.dalcim == dal).ToList().ForEach(x => Console.WriteLine($"A {x.szinpadSorszam}. színpadon hallható."));
            }
            else
            {
                Console.WriteLine("A dal nem szerepel a fesztiválon.");
            }
            Console.WriteLine();

            Console.WriteLine($"6. feladat: a popzenei dalok összesített szakmai pontszáma: {adatok.Where(x=>x.stilus=="Pop").Sum(x=>x.szakmaiPont)} pont");
            Console.WriteLine();

            Console.WriteLine($"7. feladat: A szavazáson leadott szavazatok száma: {adatok.Sum(x=>x.szavazatok)} db, átlagosan {adatok.Sum(x=>x.szavazatok)/98765.0:0.00} szavazat");
            Console.WriteLine();

            Console.WriteLine("8. feladat: A stílusokszavazati aránya:");
            double összes = adatok.Sum(x=>x.szavazatok);
            adatok.GroupBy(x => x.stilus).ToList().ForEach(x => Console.WriteLine($"{x.Key} - {x.Sum(y=>y.szavazatok)/összes*100:0.00} %"));
            Console.WriteLine();

            Console.WriteLine($"A legtöbb közönségszavazatot kapott dal: {adatok.OrderByDescending(x=>x.szavazatok).First().dalcim} (Stílus: {adatok.OrderByDescending(x => x.szavazatok).First().stilus}) - {adatok.OrderByDescending(x => x.szavazatok).First().szavazatok} szavazat");
            Console.WriteLine();

            StreamWriter sw = new StreamWriter("statisztika.txt");
            adatok.GroupBy(x => x.szinpadSorszam).OrderBy(x => x.Key).ToList().ForEach(x => sw.WriteLine($"{x.Key}. színpad - elhangzott dalok száma: {x.Count()}"));
            sw.Close();
            Console.WriteLine("10. feladat: Statisztika sikeresen exportálva (statisztika.txt)");
        }
    }
}
