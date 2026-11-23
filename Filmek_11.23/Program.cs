
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmek_11._23
{
    internal class Program
    {
        static List<Horror> horrorFilmek = new List<Horror>();
        static List<Akcio> akcioFilmek = new List<Akcio>();
        static List<Tortenelmi> tortenelmiFilmek = new List<Tortenelmi>();

        static string Cim()
        {
            Console.WriteLine("Film címe: ");
            string cim = Console.ReadLine();
            return cim;
        }

        static string Rendezo()
        {
            Console.WriteLine("Film rendezője: ");
            string rendezo = Console.ReadLine();
            return rendezo;
        }

        static int Hossz()
        {
            Console.WriteLine("Film hossza: ");
            int hossz = Convert.ToInt32(Console.ReadLine());
            return hossz;
        }

        static int Korhatar()
        {
            Console.WriteLine("Film korhatára: ");
            int korhatar = Convert.ToInt32(Console.ReadLine());
            return korhatar;
        }

        static double Ertekeles()
        {
            Console.WriteLine("Film értékelése: ");
            double ertekeles = Convert.ToDouble(Console.ReadLine());
            return ertekeles;
        }

        static void HorrorFilmek()
        {
            foreach (var item in horrorFilmek)
            {
                item.Veites();
                Console.WriteLine(item.FilmAdatok());
                Console.WriteLine();
            }
        }
        static void AkcioFilmek()
        {
            foreach (var item in akcioFilmek)
            {
                item.Veites();
                Console.WriteLine(item.FilmAdatok());
                Console.WriteLine();
            }
        }
        static void TortenelmiFilmek()
        {
            foreach (var item in tortenelmiFilmek)
            {
                item.Veites();
                Console.WriteLine(item.FilmAdatok());
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            
            try
            {
                horrorFilmek.Add(new Horror("Sikoly", "Pali", 122, 8.2, 18));

                HorrorFilmek();

                Console.WriteLine();

                akcioFilmek.Add(new Akcio("Diehard", "Bruce Willys", 110, 7.3, 16, 1));

                AkcioFilmek();

                Console.WriteLine();

                tortenelmiFilmek.Add(new Tortenelmi("Egri Csillagok", "Gárdonyi Géza", 250, 5.2, 12, 1552));

                TortenelmiFilmek();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            bool igaz = true;

            do
            {
                Console.WriteLine("Milyen filmet szeretnél hozzáadni?\n\tHorror: h\n\tAkció: a\n\tTörténelni: t\n\tBármi más: kilépés");
                char betu = Convert.ToChar(Console.ReadLine());
                if (betu=='h' || betu=='a' || betu=='t')
                {
                    string cim = Cim();
                    string rendezo = Rendezo();
                    int hossz = Hossz();
                    int korhatar = Korhatar();
                    double ertekeles = Ertekeles();

                    switch (betu)
                    {
                        case 'h':
                            horrorFilmek.Add(new Horror(cim, rendezo, hossz, ertekeles, korhatar));
                            HorrorFilmek();
                            break;
                        case 'a':
                            Console.WriteLine("Szereplők száma: ");
                            int szereplok = Convert.ToInt32(Console.ReadLine());
                            akcioFilmek.Add(new Akcio(cim, rendezo, hossz, ertekeles, korhatar, szereplok));
                            AkcioFilmek();
                            break;
                        case 't':
                            Console.WriteLine("Mikor játszódik? ");
                            int jatszodik = Convert.ToInt32(Console.ReadLine());
                            tortenelmiFilmek.Add(new Tortenelmi(cim, rendezo, hossz, ertekeles, korhatar, jatszodik));
                            TortenelmiFilmek();
                            break;
                        default:
                            igaz = false;
                            break;
                    }
                }
                else
                {
                    igaz = false;
                }
            }
            while (igaz);
        }
    }
}
