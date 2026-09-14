using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Schumacher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Verseny> adatok = new List<Verseny>();
            File.ReadAllLines("schumacher.csv").Skip(1).ToList().ForEach(x => adatok.Add(new Verseny(x)));

            Console.WriteLine($"3. feladat: {adatok.Count}");

            Console.WriteLine();

            Console.WriteLine($"4. feladat: Schumacher {adatok.Where(x=>x.grandprix== "Hungarian Grand Prix").Count()} alkalommal szerepelt a Magyar Nagydíjon");
            Console.WriteLine("Sikeres szereplései:");
            adatok.Where(x =>x.grandprix == "Hungarian Grand Prix" && x.position!=0).ToList().ForEach(x=> Console.WriteLine($"{x.date}: {x.position}. hely"));

            Console.WriteLine();

            Console.WriteLine("5. feladat: Hibastatisztika");
            adatok.Where(x => x.position == 0).GroupBy(x => x.status).Where(x=>x.Count()>=2).ToList().ForEach(x => Console.WriteLine($"{x.Key} - {x.Count()}"));
        }
    }
}
