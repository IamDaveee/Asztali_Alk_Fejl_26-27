using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okosotthon
{
    abstract class Okoseszközök
    {
       string Nev { get; set; }
       int Azonosito { get; set; }
       public abstract bool Bekapcsolva { get; set; }
       public abstract double Teljesitmeny { get; set; }
        
        protected Okoseszközök(string nev, int azonosito, double teljesitmeny)
        {
            Nev = nev;
            Azonosito = azonosito;
            Teljesitmeny = teljesitmeny;
            Bekapcsolva = false;
        }

        public virtual string Kapcsolo()
        {
            Bekapcsolva = !Bekapcsolva;
            return Bekapcsolva ?$"Az eszköz állapota: Bekapcsolva":$"Az eszköz állapota: Kikapcsolva";
        }

        public string Kiir()
        {
            if (Bekapcsolva)
            {
                return $"Azonosító: {Azonosito}, Név: {Nev}, Állapota: Bekapcsolva";
            }
            else
            {
                return $"Azonosító: {Azonosito}, Név: {Nev}, Állapota: Kikapcsolva";
            }
        }

        public abstract string Aktualis();
        public abstract string Diagnosztika();
    }
}
