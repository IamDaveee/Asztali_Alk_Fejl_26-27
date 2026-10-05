using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jellemzők
{
    internal class Kutya7
    {
        //privált setter
        public string Nev { get; }
        //kor: kívülről olvasható, belülről írható
        public int Kor { get; private set; }

        public Kutya7(string nev, int kor)
        {
            Nev = nev;
            Kor = kor; //kezdőérték
        }

        public void Szuletesnap()
        {
            Kor++;
            Console.WriteLine($"Boldog születésnapot {Nev}, {Kor} éves lettél");
        }
    }
}
