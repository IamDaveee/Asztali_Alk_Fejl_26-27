using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Öröklődés_3
{
    internal class Olvasmany
    {
        //1. private adattagok
        string cim, szerzo;
        int kiadasEve;

        //2. jellemzők készítése
        public string Cim
        {
            get => cim;
            set => cim = string.IsNullOrEmpty(value)
                ? throw new Exception("A cím nem lehet üres értékű")
                : value.ToUpper();
        }

        /*
        public string Cim
        {
            get
            {
                return cim;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("A cím nem lehet üres értékű");
                }
                else
                {
                    value.ToUpper();
                }
            }
        }
        */

        public string Szerzo
        {
            get => szerzo;
            set => szerzo = string.IsNullOrEmpty(value)
                ? throw new Exception("Hiba: ")
                : value;
        }

        public int KiadasEve
        {
            get => kiadasEve;
            set => kiadasEve = value >= 1500 && value <= DateTime.Now.Year
                ? value
                : throw new Exception($"Hiba: Kiadás éve 1500 és {DateTime.Now.Year} év között lehet");
        }

        //3. konstruktor
        public Olvasmany(string cim, string szerzo, int kiadasEve)
        {
            Cim = cim;
            Szerzo = szerzo;
            KiadasEve = kiadasEve;
        }

        public Olvasmany(string cim, string szerzo)
        {
            Cim = cim;
            Szerzo = szerzo;
            KiadasEve = 1500;
        }

        //5.
        public virtual void Kiir()
        {
            Console.WriteLine($"Az olvasmany címe: {Cim}");
            Console.WriteLine($"Az olvasmány szezője: {Szerzo}");
            Console.WriteLine($"Az olvasmány kora: {Kora()}");
        }

        public int Kora()
        {
            return DateTime.Now.Year - KiadasEve;
        }

        
    }
}
