using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otthoni_11._08
{
    internal class HusosRecept : Recept
    {
        string husTipus;
        int SutesHomerseklet { get; set; }

        public string HusTipus
        {
            get => husTipus;
            set => husTipus = value == "csirke" || value == "marha" || value == "hal" || value == "sertés" ? value : throw new Exception("A hús típusa csak csirke, marha, sertés vagy hal lehet!");
        }

        public HusosRecept(string nev, List<string> osszetevetok, int elkeszitesiIdo, DateTime letrehozasiIdo, string husTipus, int sutesiHomerseklet) : base(nev, osszetevetok, elkeszitesiIdo, letrehozasiIdo)
        {
            HusTipus = husTipus;
            SutesHomerseklet = sutesiHomerseklet;
        }

        public HusosRecept(string nev, List<string>osszetevok, string hustipus, int homerseklet) : base(nev, osszetevok)
        {
            HusTipus = hustipus;
            SutesHomerseklet = homerseklet;
        }

        public override string HozzavalokListazasa()
        {
            return base.HozzavalokListazasa() + $"Tipus: {HusTipus} Hőmérséklete: {SutesHomerseklet}";
        }
    }
}
