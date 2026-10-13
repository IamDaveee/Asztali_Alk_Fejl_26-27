using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuldemenyek
{
    internal class BelfoldiCsomag : Kuldemeny
    {
        int korzetSzam;

        public int KorzetSzam
        {
            get => korzetSzam;
            set => korzetSzam = value < 1 || value > 99 ? throw new Exception("Hiba! A körzetszámnak 1 és 99 között kell lennie") : value;
        }

        public BelfoldiCsomag(string cimzett, string vonalkod, double suly, int korzetSzam) : base(cimzett, vonalkod, suly)
        {
            KorzetSzam = korzetSzam;
        }

        public BelfoldiCsomag() :base()
        {
            KorzetSzam = 1;
        }

        public override string Statusz()
        {
            return base.Statusz() + $"Kézbesítési körzet: {KorzetSzam}";
        }

        public override string KezelesiUtasitas()
        {
            return base.KezelesiUtasitas() + $"Kiegészítő utasítás: Belföldi terítési hálózat.";
        }

        public override void Frissit()
        {
            base.Frissit();
            try
            {
                Console.WriteLine("Új körzetszám (1 és 99 között): ");
                int korSzam = Convert.ToInt32(Console.ReadLine());
                KorzetSzam = korSzam;
                Console.WriteLine("A körzetszám frissítve lett");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hiba! {ex.Message}");
            }
        }
    }
}
