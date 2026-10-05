using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jellemzők
{
    internal class Kutya3
    {
        string nev;
        int kor;

        public string Nev
        {
            get
            {
                return nev;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    //throw new Exception("A név nemmegfelelő");
                    Console.WriteLine("Hiba");
                }
                nev = value;
            }
        }

        public int Kor
        {
            get
            {
                return kor;
            }
            set
            {
                if (value<1)
                {
                    //throw new Exception("Nemmegfelelő életkor");
                    Console.WriteLine("Hiba");
                }
                kor = value;
            }
        }

        //konstruktor
        public Kutya3(string nev, int kor)
        {
            //jellemzőkön keresztüli értékadás
            Nev = nev;
            Kor = kor;
        }

        public Kutya3()
        {
            
        }
    }
}
