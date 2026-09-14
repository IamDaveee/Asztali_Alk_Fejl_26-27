using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;

namespace Diáktanya
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<AjtoLog> adatok = new List<AjtoLog>();
            File.ReadLines("diaktanya_log.txt").Skip(1).ToList().ForEach(x=>adatok.Add(new AjtoLog(x)));

            Console.WriteLine($"5. feladat: Az állományban {adatok.Count} sor található");

            Console.WriteLine("6. feladat: Kérek egy diák nevet: ");
            string nev = Console.ReadLine();
            Console.WriteLine($"{nev} a diáktanyán:");
            if (adatok.Any(x=>x.nev==nev))
            {
                adatok.Where(x => x.nev == nev).ToList().ForEach(x => Console.WriteLine($"{x.beOra:00}:{x.bePerc:00} - {x.kiOra:00}:{x.kiPerc:00}"));
            }
            else
            {
                Console.WriteLine("Nem járt a diáktanyán!");
            }

            Console.WriteLine("7.feladat: Adjon meg egy időpontot óra:perc alakban");
            string[] idopont = Console.ReadLine().Split(':');
            Console.WriteLine("Diáktanyán lévő tanulók:");
            int percben = Convert.ToInt32(idopont[0]) * 60 + Convert.ToInt32(idopont[1]);
            adatok.Where(x=>x.beOraPerc<=percben && x.kiOraPerc>=percben).ToList().ForEach(x=> Console.WriteLine($"{x.beOra:00}:{x.bePerc:00} - {x.kiOra:00}:{x.kiPerc:00} : {x.nev}"));

            Console.WriteLine($"8. feladat: Az átlagos benttartózkodás: {Math.Round(adatok.Average(x=>x.kiOraPerc-x.beOraPerc), 2)} perc");

            StreamWriter sw = new StreamWriter("C.txt");
            adatok.Where(x => x.azon == "C").ToList().ForEach(x => sw.WriteLine($"{x.beOra:00}:{x.bePerc:00} - {x.kiOra:00}:{x.kiPerc:00} : {x.nev} ({x.kiOraPerc-x.beOraPerc}perc)"));
            sw.Close();

            Console.WriteLine("10. feladat: Statisztika");
            adatok.OrderBy(x => x.azon).GroupBy(x => x.azon).ToList().ForEach(x => Console.WriteLine($"{x.Key} - {x.Count()}"));
        }
    }
}
