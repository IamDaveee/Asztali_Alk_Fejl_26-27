using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Okosotthon_11_16
{
    internal class Okosredony:Okoseszkoz
    {

        int arnyekolo;
        int manualisE;
        string szoveg;
        public int Arnyekolo
        {
            get => arnyekolo;
            set 
            {
                if (value > 100 || value < 0)
                {
                    arnyekolo = 0;
                    throw new Exception("A redőny értéke nem lehet 100-nál nagyobb vagy 0-nál kisebb");
                }
                else
                {
                    arnyekolo= value;
                }
                
            }
        }
        public int ManualisE 
        {
            get => manualisE;
            set => manualisE = value;

        }
        public string Szoveg 
        {
            get => szoveg;
            set => szoveg = value;
        }

        public Okosredony(string tipus, int id, bool bekapcsolt, int fogyasztas,int arnyekolo,int manualisE):base(tipus, id, bekapcsolt, fogyasztas) 
        {
            Arnyekolo = arnyekolo;
            ManualisE= manualisE;
        }
        public void RedonyAllapot()
        {
            if (arnyekolo == 0)
            {
                szoveg="A redőny nappali üzemmódba lépett";
                arnyekolo = 0;
            }
            if (arnyekolo == 100)
            {
                szoveg="A redőny éjszakai üzemmódba lépett";
                arnyekolo = 100;
            }
        }
        

        public override string AktualE()
        {
            return $"{Fogyasztas==1.2}";
        }
        public override string Diag()
        {
            return $"{AktualE()} w a redőny fogyasztása és jelenleg {Szoveg} ";
        }


    }
}
