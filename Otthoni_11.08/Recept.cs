using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otthoni_11._08
{
    internal class Recept
    {
        string nev;
        List<string> osszetevok;
        int elkeszitesiIdo;
        DateTime letrehozasIdeje;

        public string Nev{
            get => nev;

            //set => nev = string.IsNullOrEmpty(value) ? throw new Exception("A recept neve nem lehet üres!") : value;

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("A recept neve nem lehet üres!");
                }
                else
                {
                    nev = value;
                }
            }
        }

        public int ElkeszitesiIdo
        {
            get=> elkeszitesiIdo;

            set => elkeszitesiIdo = value <= 0 ? throw new Exception("Az elkészítési időnek pozitívnak kell lennie!") : value;
        }

        public List<string> Osszetevok
        {
            get => osszetevok;

            set
            {
                if (value.Count<1)
                {
                    throw new Exception("A receptnek legalább egy összetevőt kell tartalmaznia!");
                }
                else
                {
                    osszetevok = value;
                }
            }
        }

        public DateTime LetrehozasIdeje
        {
            get => letrehozasIdeje;

            set => letrehozasIdeje = value < Convert.ToDateTime("2000.01.01") || value > DateTime.Now ? throw new Exception("Invalid dátum!") : value;
        }

        public Recept(string nev, List<string> osszetevetok, int elkeszitesiIdo, DateTime letrehozasiIdo)
        {
            Nev = nev;
            Osszetevok = osszetevetok;
            ElkeszitesiIdo = elkeszitesiIdo;
            LetrehozasIdeje = letrehozasiIdo;
        }

        public Recept(string nev, List<string> osszetevetok)
        {
            Nev = nev;
            Osszetevok = osszetevetok;
            ElkeszitesiIdo = 30;
            LetrehozasIdeje = DateTime.Now;
        }

        public Recept(string nev)
        {
            Nev = nev;
            Osszetevok = new List<string>();
            ElkeszitesiIdo = 1;
            LetrehozasIdeje = Convert.ToDateTime("2000.01.01");
        }

        public virtual string HozzavalokListazasa()
        {
            string lista="";
            foreach (var item in Osszetevok)
            {
                lista += $"{Convert.ToString(item)}, ";
            }
            return lista;
        }

        public virtual string AllergenekEllenorzese()
        {
            string allergenek = "";
            if (Osszetevok.Contains("glutén"))
            {
                allergenek += "glutén,";
            }
            if (Osszetevok.Contains("tej"))
            {
                allergenek += "tej,";
            }
            if (Osszetevok.Contains("tojás"))
            {
                allergenek += "tojás,";
            }
            if (Osszetevok.Contains("dió"))
            {
                allergenek += "dió,";
            }

            if (string.IsNullOrEmpty(allergenek))
            {
                return "A recept nem tartalmaz ismert allergéneket.";
            }
            else
            {
                return $"Figyelem! A recept allergéneket tartalmaz: {allergenek}";
            }
        }
    }
}
