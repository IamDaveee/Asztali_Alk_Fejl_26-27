using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuldemenyek
{
    internal class Kuldemeny
    {
        string cimzett, vonalkod, szallitasiKategoria;
        double suly;

        public string Cimzett{
            get => cimzett;
            set=>cimzett=string.IsNullOrEmpty(value) || value.Split(',').Length != 2 ? throw new Exception("Hiba! A nevet és címet vesszővel kell elválasztani!") : value;
        }

        public string Vonalkod
        {
            get => vonalkod;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Hiba! A vonalkód nem lehet üres értékű!");
                }
                if (value.Length != 9)
                {
                    throw new Exception("Hiba! A vonalkódnak pontosan 9 karakter hosszúságúnak kell lennie!");
                }
            }
        }

        public double Suly
        {
            get => suly;
            set => suly = value < 0 || value > 50 ? throw new Exception("Hiba! A súlynak 1 és 50 között kell lennie!") : value;
        }

        public string SzallitaiKategoria
        {
            get => szallitasiKategoria;
            private set
            {
                string character = vonalkod.Substring(0, 1).ToUpper();
                switch (character)
                {
                    case "E":
                        {
                            szallitasiKategoria = "Expressz szállítás (24 órás garantált)";
                            break;
                        }
                    case "S":
                        {
                            szallitasiKategoria = "Standard szállítás (szokásos átfutás)";
                            break;
                        }
                    case "N":
                        {
                            szallitasiKategoria = "Nemzetközi szállítás (vámköteles)";
                            break;
                        }
                    default:
                        break;
                }
            }
        }

        public bool Szallithato
        {
            get
            {
                return suly <= 40 ? true : false;
            }
        }

        public Kuldemeny(string cimzett, string vonalkod, int suly)
        {
            Cimzett = cimzett;
            Vonalkod = vonalkod;
            Suly = suly;
        }

        public Kuldemeny()
        {
            Cimzett = "Ismeretlen Ügyfél, Minta utca 1";
            Vonalkod = "S00000000";
            Suly = 1.0;
        }

        public void Statusz()
        {
            Console.WriteLine($"A(z) $@{Vonalkod} vonalkódú csomag úton van. Címzett: {Cimzett}. Súly: {Suly}.kg");
        }

        public int Napok()
        {
            int napok = Suly < 10 ? 1 : 3;
            return napok;
        }

        public void Frissit()
        {
            if (Vonalkod != "S00000000")
            {
                Console.WriteLine("A küldemény adatai nem frissíthetők, mert már nem az alapértelmezett értékekkel rendelkezik!");
                return;
            }
            Console.WriteLine(" --- Küldemény adatainak frissítése --- ");
            Console.WriteLine("Kérem az új címzettet (Név, Cím formátumban): ");
            string cimzett = Console.ReadLine();

            Console.WriteLine("Kérem az új vonalkódot (pontosan 9 karakter hosszúságú legyen): ");
            string vonalkod = Console.ReadLine();

            Console.WriteLine("Kérem a csomag új súlyát (kg): ");
            int suly = Convert.ToInt32(Console.ReadLine());

            try
            {
                Cimzett = cimzett;
                Vonalkod = vonalkod;
                Suly = suly;
                Console.WriteLine("Sikeres adatfrissítés!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Sikertelen frissítés! {ex.Message}");
            }
            
        }

        public void KezelesiUtasitas()
        {
            Console.WriteLine($"A(z) {Vonalkod} azonosítójú küldemény kezelése: {SzallitaiKategoria} szabályai szerint.");
        }
    }
}
