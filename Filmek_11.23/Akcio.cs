using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmek_11._23
{
    internal class Akcio : Filmek
    {
        int Szereplok { get; set; }
        int korhatar;

        public override int Korhatar { get => korhatar; }

        public int KorH
        {
            get => korhatar;
            set => korhatar = value >= 16 ? value : throw new Exception("A korhatárnak 16 vagy többnek kell lennie");
        }

        public Akcio(string cim, string rendezo, int hossz, double ertekeles, int korhatar, int szereplok) : base(cim, rendezo, hossz, ertekeles)
        {
            KorH = korhatar;
            Szereplok = szereplok;
        }

        public override void Veites()
        {
            Console.WriteLine("Az Akció filmeket napközben is vetítik.\n");
        }

        public override string FilmAdatok()
        {
            return base.FilmAdatok() + $"Szereplők száma: {Szereplok}\n" + Cselekmeny();
        }

        public string Cselekmeny()
        {
            return Hossz > 120 ? "A film komplikált" : "A film akciódús";
        }
    }
}
