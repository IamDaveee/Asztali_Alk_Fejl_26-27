using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmek_11._23
{
    internal class Horror : Filmek
    {
        bool Ajanlott { get; }
        int korH;

        public override int Korhatar { get => korH; }

        public int KorH
        {
            get => korH;
            set=>korH=value>=18? value:throw new Exception("A korhatárnak 18 vagy többnek kell lennie");
        }

        public Horror(string cim, string rendezo, int hossz, double ertekeles, int korhatar) : base(cim, rendezo, hossz, ertekeles)
        {
            KorH = korhatar;
            if (ertekeles > 8.0)
            {
                Ajanlott = true;
            }
            else
            {
                Ajanlott = false;
            }
        }

        public override void Veites()
        {
            Console.WriteLine("A Horror filmek vetítése általában késő estére esik.");
        }

        public override string FilmAdatok()
        {
            return base.FilmAdatok() + $"{(Ajanlott?"Ajánlott.":"Nem ajánlott.")}\n" + Ijeszto();
        }

        public string Ijeszto()
        {
            if (Ertekeles<6)
            {
                return $"A film egyáltalán nem ijesztő";
            }
            else if (Ertekeles >=6 && Ertekeles < 8)
            {
                return $"A film egy kicsit ijesztő";
            }
            else
            {
                return $"A film nagyon brutális, csak saját felelősségre nézendő";
            }
        }
    }
}