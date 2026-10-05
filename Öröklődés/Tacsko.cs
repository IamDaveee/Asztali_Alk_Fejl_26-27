using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Öröklődés
{
    internal class Tacsko : Kutya
    {
        public Tacsko(string nev, string fajta) : base(nev, fajta)
        {

        }

        public override void Eves()
        {
            base.Eves(); //Hívja az ős metódusát
            Console.WriteLine($"Ropogtatnak");
        }

        public override void Lakohely()
        {
            Console.WriteLine("Kutyaszőnyeg");
        }
    }
}
