using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jellemzők
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kuyta kutya = new Kuyta("Buksi", 2);
            Console.WriteLine($"Neve: {kutya.nev}, kora: {kutya.kor}");

            Kutya2 kutya2 = new Kutya2("Cézár", 1);
            //Console.WriteLine($"{kutya2.nev}");
            Console.WriteLine($"A kutya neve: {kutya2.KutyaNeve()}, kora: {kutya2.Kora()}");
            Kutya2 kutya22 = new Kutya2("Milán", -5);
            Console.WriteLine($"A kutya neve: {kutya22.KutyaNeve()}, kora: {kutya22.Kora()}");

            Kutya3 kutya3 = new Kutya3();
            kutya3.Nev = "";
            kutya3.Kor = 500;
            Console.WriteLine($"Neve: {kutya3.Nev}, kora: {kutya3.Kor}");

            Kutya3 kutya33 = new Kutya3("Frenszisz", 66);
            Console.WriteLine($"Neve: {kutya33.Nev}, kora: {kutya33.Kor}");

            Kutya4 kutya4 = new Kutya4("Bálint", 13);
            Console.WriteLine(kutya4.Kiir());

            Kutya5 kutya5 = new Kutya5("Kifli", 12);
            Console.WriteLine($"Neve: {kutya5.Nev}, kora: {kutya5.Kor}");
            //kutya5.Nev = "Tigris"; //hibás, csak olvasható

            Kutya5 kutya55 = new Kutya5();
            Console.WriteLine($"Neve: {kutya55.Nev}, kora: {kutya55.Kor}");

            Kutya6 kutya6 = new Kutya6("Mázli", 8);
            Console.WriteLine($"Neve: {kutya6.Nev}, kora: {kutya6.Kor}");
            kutya6.ChipSzam = "123456789012345";
            //Console.WriteLine(kutya6.ChipSzam);

            Kutya7 kutya7 = new Kutya7("Kerberosz", 3);
            Console.WriteLine($"{kutya7.Nev} kuyta jelenleg {kutya7.Kor} éves");
            kutya7.Szuletesnap();
            Console.WriteLine($"{kutya7.Nev} kuyta jelenleg {kutya7.Kor} éves");

            Kutya8 kutya8 = new Kutya8("Hektor");
            Console.WriteLine($"Kutyák száma: {Kutya8.KutyakSzama}");
            Kutya8 kutya88 = new Kutya8("Cupcake");
            Console.WriteLine($"Kutyák száma: {Kutya8.KutyakSzama}");

        }
    }
}
