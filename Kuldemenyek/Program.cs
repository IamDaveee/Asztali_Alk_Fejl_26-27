using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuldemenyek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kuldemeny kuldemeny1 = new Kuldemeny("Kovács Péter, Fő utca 12", "E12345678", 12.5);
            Kuldemeny kuldemeny2 = new Kuldemeny();

            BelfoldiCsomag belfoldi1 = new BelfoldiCsomag("Nagy Anna, Kossuth tér 5", "S98765432", 5.2, 42);
            BelfoldiCsomag belfoldi2 = new BelfoldiCsomag();

            ErtekesCsomag ertekes1 = new ErtekesCsomag("Kiss Gábor, Vámház körút 8", "N45612378", 0.8, "Okostelefon", 180000);
            ErtekesCsomag ertekes2 = new ErtekesCsomag();

            try
            {
                Console.WriteLine(kuldemeny1.Statusz());
                Console.WriteLine(kuldemeny1.KezelesiUtasitas());
                Console.WriteLine(kuldemeny1.Napok());

                Console.WriteLine();

                Console.WriteLine(belfoldi1.Statusz());
                Console.WriteLine(belfoldi1.KezelesiUtasitas());
                Console.WriteLine(belfoldi1.Napok());

                Console.WriteLine();

                Console.WriteLine(ertekes1.Statusz());
                Console.WriteLine(ertekes1.KezelesiUtasitas());
                Console.WriteLine(ertekes1.Napok());

                Console.WriteLine();

                Console.WriteLine(belfoldi1.Statusz());
                Console.WriteLine(belfoldi1.Szallithato ? "A csomag szállítható" : "A csomag nem szállítható");

                Console.WriteLine();

                Console.WriteLine(ertekes1.KezelesiUtasitas());
                Console.WriteLine(ertekes1.Statusz());

                Console.WriteLine();

                belfoldi2.Frissit();
                belfoldi2.Statusz();

                Console.WriteLine();

                kuldemeny1.Frissit();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hiba! {ex.Message}");
            }
        }
    }
}