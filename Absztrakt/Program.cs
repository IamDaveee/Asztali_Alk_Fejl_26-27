using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Absztrakt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //Alakzat a = new Alakzat("zold");
            Kor k = new Kor("purple", 5);
            Console.WriteLine($"{k.r} cm sugarú kör területe: {k.Terulet()}");
            k.Kiir();
            Console.WriteLine(k.ToString());

            Teglalap t = new Teglalap("Fekete", 4, 2.5);
            Console.WriteLine($"{t.Aoldal} * {t.Boldal} téglalap területe: {t.Terulet()}");
            t.Kiir();
            Console.WriteLine(t.ToString());
            

            
            List<Allat> allatok = new List<Allat>()
            {
                new Kutya("Cézár",5,"Jóska"),
                new Macska("Cirmi", 1, true)
            };

            foreach (var item in allatok)
            {
                item.Eszik();
                item.HangotAd();
                Console.WriteLine($"{item.GetType().Name} - {item.Nev}");
            }
            

            List<Jarmu> jarmuvek = new List<Jarmu>()
            {
                new Auto("Bentli", "Continental",500000, "JB-007"),
                new Versenyauto("Opel", "Asztra", 10000, 1200,"ABC-123")
            };
            foreach (var item in jarmuvek)
            {
                Console.WriteLine(item.ToString());
                Console.WriteLine($"Bérleti díj: {item.BerletiDij(10)}");
            }
        }
    }
}
