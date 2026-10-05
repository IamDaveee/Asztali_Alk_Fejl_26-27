using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jellemzők
{
    internal class Kutya2
    {
        private string nev;
        int kor; //alapértelmezetten privált

        /*
        public Kutya2(string nev, int kor)
        {
            this.nev = nev;
            this.kor = kor;
        }
        */

        public Kutya2(string nev, int kor)
        {
            this.nev = nev;
            //mwetódus az életkor ellenőrzésre
            KorBeallit(kor);
        }

        //metódus, ami lekérdezi a kutya adatait
        public int Kora()
        {
            return kor;
        }

        public string KutyaNeve() => nev; //ugyan az, csak lambda

        public void KorBeallit(int kor)
        {
            if (kor<1)
            {
                Console.WriteLine("érvénytelen életkor");
            }
            else
            {
                this.kor = kor;
            }
        }

        /*
        public void KorBeallit(int kor) => kor = kor < 1 ?
            throw new Exception("Érvénytelen életkor")
            :
            this.kor = kor;
        */
    }
}
