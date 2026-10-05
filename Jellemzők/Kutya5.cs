using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jellemzők
{
    internal class Kutya5
    {
        //csak olvasható
        public string Nev { get; }
        public int Kor { get; }

        public Kutya5(string nev, int kor)
        {
            Nev = nev;
            Kor = kor;
        }

        public Kutya5()
        {
            Nev = "Morzsa";
            Kor = 2;
        }
    }
}
