using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Absztrakt
{
    abstract class Alakzat
    {
        //nem lehet példányosítani - nincs "new"- val létrehozás
        //speciális, hiényos osztály
        //a származtatott osztályok fogják implementálni
        //alaposztály, ősoszály

        //adattagok, jellemzők
        public string Szin { get; set; }

        //konstruktor - public/protected
        protected Alakzat(string szin)
        {
            Szin = szin;
        }

        //absztrakt metódusok
        //nem tartalmaz törzset, implemetációt - a gyerek osztályok fogják megvalósítani
        //csak absztrakt osztályokban szerepelhet
        public abstract double Terulet();

        //normál metódus
        public void Kiir()
        {
            Console.WriteLine($"Alakzat színe: {Szin}");
        }

        //Object osztályból örökölt ToString()
        public override string ToString()
        {
            return $"Ez egy {Szin} alakzat.";
        }
    }
}
