using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jellemzők
{
    internal class Kutya4
    {
        public string Nev { get; set; }
        int kor;
        public int Kor { get => kor; set => kor=value; }

        public string Fajta { get; set; } = "keverék";

        public Kutya4(string nev, int kor)
        {
            Nev = nev;
            Kor = kor;
        }

        public string Kiir()
        {
            return $"A kutya neve: {Nev}, kutya kora: {Kor}, fajtája: {Fajta}";
        }
    }
}
