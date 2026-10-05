using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Öröklődés
{
    internal class Allatok
    {
        public string Nev { get; set; }

        public Allatok()
        {
            Nev = "állatka";
        }

        public Allatok(string nev)
        {
            Nev = nev;
        }

        public virtual void Koszon()
        {
            Console.WriteLine($"Szia, én egy állat vagyok, nevem: {Nev}");
        }

        public virtual void Eves()
        {
            Console.WriteLine($"Az állatok gyorsan esznek");
        }

        public virtual void Lakohely()
        {
            Console.WriteLine("Természet");
        }
    }
}
