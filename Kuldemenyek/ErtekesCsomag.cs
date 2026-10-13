using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuldemenyek
{
    internal class ErtekesCsomag : Kuldemeny
    {
        string Tartalom { get; set; }
        int bejelentettErtek;

        public int BejelentettErtek
        {
            get => bejelentettErtek;
            set=>bejelentettErtek = value < 10000 || value > 2000000 ? throw new Exception("Hiba! Az értéknek 10000 és 2000000 Ft között kell lennie") : value;
        }
        public ErtekesCsomag(string cimzett, string vonalkod, double suly, string tartalom, int bejelentettErtek) : base(cimzett, vonalkod, suly)
        {
            Tartalom = tartalom;
            BejelentettErtek=bejelentettErtek;
        }
        public ErtekesCsomag() :base()
        {
            Tartalom = "dokumentum";
            BejelentettErtek = 10000;
        }

        public override string Statusz()
        {
            return base.Statusz() + $"A csomag értékes tartalma: {Tartalom}, biztosított érték: {BejelentettErtek} Ft.";
        }

        public override string KezelesiUtasitas()
        {
            return base.KezelesiUtasitas() + $"Kiegészítő utasítás: Fokozott biztonsági felügyelet.";
        }

        public override void Frissit()
        {
            base.Frissit();
            try
            {
                Console.WriteLine("Új tartalom: ");
                string tart = Console.ReadLine();
                Tartalom = tart;
                Console.WriteLine("Összege (10000-2000000 Ft között): ");
                int osszeg = Convert.ToInt32(Console.ReadLine());
                BejelentettErtek = osszeg;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hiba! {ex.Message}");
            }
        }
    }
}
