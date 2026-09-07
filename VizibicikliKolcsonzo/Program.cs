using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace VizibicikliKolcsonzo
{
    internal class Program
    {
        static List<Kolcsonzes> kolcsonzesek = new List<Kolcsonzes>();
        static void Main(string[] args)
        {
            File.ReadAllLines("kolcsonzesek.txt").Skip(1).ToList().ForEach(x => kolcsonzesek.Add(new Kolcsonzes(x)));

            foreach (var item in kolcsonzesek)
            {
                Console.WriteLine($"{item.nev};{item.jazon};{item.elvitelOra};{item.elvitelPerc};{item.visszaOra};{item.visszaPerc}");
            }
            Console.WriteLine(kolcsonzesek.Count);

            Console.WriteLine("Melyik személyt keressük?");
            string nev = Console.ReadLine().ToString();

            Console.WriteLine();
            
            if (kolcsonzesek.Any(x=>x.nev==nev))
            {
                Console.WriteLine("Kölcsönzései:");
                kolcsonzesek.Where(x => x.nev == nev).ToList().ForEach(x => Console.WriteLine($"{x.elvitelOra:00}:{x.elvitelPerc:00}-{x.visszaOra:00}:{x.visszaPerc:00}"));
            }
            else
            {
                Console.WriteLine($"A keresett személynek nem volt aznap kölcsönzése({nev})");
            }


            Console.WriteLine("Adjon meg egy időpontot óra:perc alakban:");
            string[] oraPerc = Console.ReadLine().Split(':');
            int ora = Convert.ToInt32(oraPerc[0]);
            int perc = Convert.ToInt32(oraPerc[1]);
            int Percben = ora * 60 + perc;
            kolcsonzesek.Where(x => x.elvOraPerc<=Percben && x.visszaOraPerc>=Percben).ToList().ForEach(x=> Console.WriteLine($"{x.elvitelOra:00}:{x.elvitelPerc:00}-{x.visszaOra:00}:{x.visszaPerc:00} - {x.nev}"));

            double osszeg = kolcsonzesek.Sum(x=>Math.Ceiling((x.visszaOraPerc-x.elvOraPerc)/30.0)*2400);
            Console.WriteLine($"Napi bevétel: {osszeg:C0}"); //C0: ezres csoportosításés pénznem (currency)

            StreamWriter sw = new StreamWriter("F.text");
            kolcsonzesek.Where(x => x.jazon == "F").ToList().ForEach(x=>sw.WriteLine($"{x.elvitelOra:00}:{x.elvitelPerc:00}-{x.visszaOra:00}:{x.visszaPerc:00} - {x.nev}"));
            sw.Close();

            Console.WriteLine("Statisztika:");
            kolcsonzesek.OrderBy(x => x.jazon).GroupBy(x => x.jazon).ToList().ForEach(x => Console.WriteLine($"{x.Key} - {x.Count()}"));
        }
        
    }
}
