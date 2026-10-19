using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Receptek
{
    internal class HusosRecept : Recept
    {
        string husTipus;

        int SutesHomerseklet { get; set; }

        public string HusTipus
        {
            get => husTipus;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Hiba! A hús typusa nem lehet üres.");
                }
                if (value=="csirke" || value == "marha" || value == "sertés" || value == "hal")
                {
                    
                }
                else
                {
                    throw new Exception("A hús típusa csak csirke, marha, sertés vagy hal lehet!");
                }
            }
        }

        public HusosRecept(string nev, List<string> osszetevok, int elkeszitesiIdo, DateTime letrehozasIdeje, string husTipus, int suteshomerseklet) : base(nev, osszetevok, elkeszitesiIdo, letrehozasIdeje)
        {
            HusTipus = husTipus;
            SutesHomerseklet=suteshomerseklet;
        }
        public HusosRecept(string nev, List<string> osszetevok, string husTipus, int suteshomerseklet):base(nev, osszetevok)
        {
            HusTipus = husTipus;
            SutesHomerseklet = suteshomerseklet;
        }

        public override void HozzavalokListazasa()
        {
            base.HozzavalokListazasa();
            Console.WriteLine($"Hústípusa: {HusTipus}, Sütési hőmérséklet: {SutesHomerseklet}");
        }
    }
}
