using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmek_11._23
{
    internal class Tortenelmi : Filmek
    {
        int jatszodik;
        int korhatar;

        public override int Korhatar { get => korhatar; }

        public int KorH
        {
            get=> korhatar;
            set => korhatar = value < 12 ? throw new Exception("A korhatárnak 12 vagy többnek kell lennie") : value;
        }

        public int Jatszodik
        {
            get => jatszodik;
            set=> jatszodik = value>Convert.ToInt32(DateTime.Now.Year)?throw new Exception("A film nem játszódhata jövőben.") : value;
        }

        public Tortenelmi(string cim, string rendezo, int hossz, double ertekeles, int korhatar, int jatszodik) : base(cim, rendezo, hossz, ertekeles)
        {
            KorH = korhatar;
            Jatszodik = jatszodik;
        }

        public override void Veites()
        {
            Console.WriteLine("A történelmi filmek vetítése napközben is megtörténik");
        }

        public override string FilmAdatok()
        {
            return base.FilmAdatok() + $"A film {Jatszodik}-ben játszódik - {Eve()} évvel ezelőtt";
        }

        public int Eve()
        {
            return Convert.ToInt32(DateTime.Now.Year) - Jatszodik;
        }
    }
}
