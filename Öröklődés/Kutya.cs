using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Öröklődés
{
    internal class Kutya:Allatok
    {
        public string Fajta { get; set; }

        public Kutya(string nev, string fajta):base(nev)
        {
            Fajta = fajta;
        }

        public void Kiir()
        {
            Console.WriteLine($"Kutya neve: {Nev}, fajtája: {Fajta}");
        }

        public override void Koszon()
        {
            Console.WriteLine($"Szai, én egy kutya vagyok, nevem: {Nev}");
            Console.WriteLine("Vau-vau");
        }

        public override void Eves()
        {
            Console.WriteLine("Csámcsog a kutya");
        }

        public new virtual void Lakohely()
        {
            Console.WriteLine("Kutyaól");
        }
    }
}
