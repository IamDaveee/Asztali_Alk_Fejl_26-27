using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Öröklődés
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Allatok allat = new Allatok();
            allat.Nev = "Cukika";
            allat.Koszon();
            Console.WriteLine();

            Kutya kutya = new Kutya("Cézár", "Labrador");
            //kutya.Koszon();
            //kutya.Nev = "Cézár";
            kutya.Koszon();
            kutya.Kiir();
            kutya.Eves();
            Console.WriteLine();

            Allatok ujAllat = new Allatok("ÚjÁllat");
            ujAllat.Koszon();
            ujAllat.Eves();
            Console.WriteLine();

            Tacsko tacsi = new Tacsko("Virsli", "Hordó");
            tacsi.Koszon();
            tacsi.Eves();
            tacsi.Lakohely();
        }
    }
}
