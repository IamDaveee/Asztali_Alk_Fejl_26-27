using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Öröklődés_4
{
    internal class Jarmu
    {
        string marka, tipus;
        int gyartasiEv;

        public string Marka
        {
            get => marka;
            set => marka = string.IsNullOrEmpty(value) ? throw new Exception("Hiba: A márka nem lehet üres") : value;
        }

        public string Tipus
        {
            get => tipus;
            set => tipus = string.IsNullOrEmpty(value) ? throw new Exception("Hiba: A Típus nem lehet üres") : value;
        }

        public int GyartasiEv
        {
            get => gyartasiEv;
            set => gyartasiEv = value < 1886 || value > DateTime.Now.Year ? throw new Exception($"Hiba: A gyártási évnek 1886 és {DateTime.Now.Year} között kell lennie") : value;
        }

        public Jarmu(string marka, string tipus, int gyartasiEv)
        {
            Marka = marka;
            Tipus = tipus;
            GyartasiEv = gyartasiEv;
        }

        public Jarmu(string marka, string tipus)
        {
            Marka = marka;
            Tipus = tipus;
            GyartasiEv = 1886;
        }

        public virtual string Megjelenit()
        {
            return RegisegE()? $"Az {Kora()} éves {Marka} {Tipus} típusú járművet {GyartasiEv}-ben gyártották, igazi régiségnek számít." : $"Az {Kora()} éves {Marka} {Tipus} típusú autót {GyartasiEv}-ben gyártották";
        }

        public int Kora()
        {
            return DateTime.Now.Year - GyartasiEv;
        }

        public bool RegisegE()
        {
            return DateTime.Now.Year - GyartasiEv > 50 ? true : false;
        }
    }
}
