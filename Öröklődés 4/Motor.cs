using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Öröklődés_4
{
    internal class Motor:Jarmu
    {
        int hengerekSzama;
        string kategoria;

        public int HengerekSzama
        {
            get => hengerekSzama;
            set => hengerekSzama = value < 1 ? throw new Exception("Hiba: A hengerek száma nem lehet negatív vagy 0") : value;
        }

        public string Kategoria
        {
            get => kategoria;
            set => kategoria = string.IsNullOrEmpty(value) ? throw new Exception("Hiba: a kategória nemlehet üres") : value;
        }

        public Motor(string marka, string tipus, int gyartasiEv, int hengerekSzama, string kategoria) : base(marka, tipus, gyartasiEv)
        {
            HengerekSzama = hengerekSzama;
            Kategoria = kategoria;
        }
        public Motor(string marka, string tipus, int hengerekSzama, string kategoria) : base(marka, tipus)
        {
            HengerekSzama = hengerekSzama;
            Kategoria = kategoria;
        }

        public override string Megjelenit()
        {
            return base.Megjelenit() + $"\nA hengerek száma: {HengerekSzama}\nKategóriája: {Kategoria}";
        }
    }
}
