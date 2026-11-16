using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Okosotthon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Okosizzo i1 = new Okosizzo("izzo", 1111, 10, 50);
            Console.WriteLine(i1.Kiir());
            Console.WriteLine(i1.Modosit(100));
            Console.WriteLine(i1.Aktualis());
            Console.WriteLine(i1.Diagnosztika());

            Console.WriteLine();

            OkosTermosztát t1 = new OkosTermosztát("Termosztát", 2222, 100, 30.0, 24.0);
            Console.WriteLine(t1.Aktualis());
            Console.WriteLine(t1.Diagnosztika());
            Console.WriteLine(t1.Modositas(22.0));
            Console.WriteLine(t1.Modositas(24.0));

            Console.WriteLine();

            OkosRedony r1 = new OkosRedony("redőny", 3333, 20);
            Console.WriteLine(r1.Diagnosztika());
            r1.Mozgatas(50);
            Console.WriteLine(r1.Diagnosztika());
            Console.WriteLine(r1.Kapcsolo());
            Console.WriteLine(r1.Diagnosztika());
            Console.WriteLine(r1.Aktualis());

            Console.WriteLine();

            List<Okoseszközök> eszkozok = new List<Okoseszközök> { i1, t1, r1 };
            double osszteljesitmeny = 0;
            foreach (Okoseszközök eszkoz in eszkozok)
            {
                Console.WriteLine(eszkoz.Kiir());
                Console.WriteLine(eszkoz.Diagnosztika());
                osszteljesitmeny = osszteljesitmeny + eszkoz.Teljesitmeny;
            }
            Console.WriteLine($"A ház pillanatnyi összfogyasztása {osszteljesitmeny}W");
        }
    }
}
