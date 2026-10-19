using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Receptek
{
    internal class Recept
    {
        string nev;
        List<string> osszetevok;
        int elkeszitesiIdo;
        DateTime letrehozasIdeje;

        string Nev
        {
            get => nev;
            set=>nev=string.IsNullOrWhiteSpace(value)  ? throw new Exception("Hiba! A név nem lehet üres!") : value;
        }
        public List<string> Osszetevok
        {
            get => osszetevok;
            set
            {
                if (value == null || value.Count < 1)
                {
                    throw new Exception(
                        "A receptnek legalább egy összetevőt kell tartalmaznia!");
                }

                osszetevok = value;
            }
        }

        int ElkeszitesiIdo
        {
            get => elkeszitesiIdo;
            set => elkeszitesiIdo = value < 1 ? throw new Exception("Hiba! Az elkészítési idő nem lehet 0 vagy negatív") : value;
        }
        DateTime LetrehozasIdeje
        {
            get => letrehozasIdeje;
            set => letrehozasIdeje = value < Convert.ToDateTime("2000.01.01") || value > DateTime.Now ? throw new Exception("Hiba! A Dátum nem kehet régebbi mint: 2000.01.01 és újabb mint a jelenlegi idő") : value;
        }

        public Recept(string nev, List<string> osszetevok, int elkeszitesiIdo, DateTime letrehozasIdeje)
        {
            Nev = nev;
            Osszetevok = osszetevok;
            ElkeszitesiIdo = elkeszitesiIdo;
            LetrehozasIdeje = Convert.ToDateTime(letrehozasIdeje);
        }
        public Recept(string nev, List<string> osszetevok)
        {
            Nev = nev;
            Osszetevok = osszetevok;
            ElkeszitesiIdo = 30;
            LetrehozasIdeje = DateTime.Now;
        }
        public Recept(string nev)
        {
            Nev = nev;
            osszetevok = new List<string>();
            ElkeszitesiIdo = 1;
            LetrehozasIdeje = Convert.ToDateTime("2000.01.01");
        }

        public virtual void HozzavalokListazasa()
        {
            string hozzavalok = "";
            foreach (var item in Osszetevok)
            {
                hozzavalok += item + ", ";
            }
            Console.WriteLine(hozzavalok.Remove(hozzavalok.Length - 2, 2));
        }

        public virtual string AllergenekEllenorzese()
        {
            if (Osszetevok.Contains("glutén") || Osszetevok.Contains("tej") || Osszetevok.Contains("tojás") || Osszetevok.Contains("dió"))
            {
                return $"Figyelem! A recept allergéneket tartalmaz: glutén, tej, tojás, dió.";
            }
            return "A recept nem tartalmaz ismert allergéneket.";
        }
    }
}
