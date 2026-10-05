using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jellemzők
{
    internal class Kutya6
    {
        //csak írható - csak set
        public string Nev { get; set; }
        public int Kor { get; set; }
        public string chipSzam;

        public string ChipSzam
        {
            set
            {
                if (value.Length==15)
                {
                    chipSzam = value;
                }
                else
                {
                    throw new Exception("A chipszám nem 15 karakter hosszú");
                }
            }
        }

        public Kutya6(string nev, int kor)
        {
            Nev = nev;
            Kor = kor;
        }
    }
}
