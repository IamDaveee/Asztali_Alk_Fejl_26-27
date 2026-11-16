using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Okosotthon_11_16
{
    internal class Okoseszkoz
    {
        string tipus;
        int id;
        bool bekapcsolt ;
        int fogyasztas;


        public string Tipus 
        {
            get => tipus;
            set => tipus = value == "izzo" || value == "termosztat" || value == "redony"?throw new Exception("A typusmal redőnynek, termosztátnak vagy izzónak kell lennie"):value;
        }
        public int Id
        {
            get => id;
            set => id = value;
        }
        public bool Bekapcsolt 
        {
            get => bekapcsolt;
            set => bekapcsolt = value;
        }
        public int Fogyasztas 
        {
            get => fogyasztas;
            set => fogyasztas = value<0 ?throw new Exception("A fogyasztás nem lehet 0 vagy negatív"):value;
        }

        public virtual string AktualE() 
        {
            return "";
        }
        public virtual string Diag()
        {
            return "";
        }

        public Okoseszkoz(string tipus, int id, bool bekapcsolt, int fogyasztas)
        {
            Tipus = tipus;
            Id = id;
            Bekapcsolt = bekapcsolt;
            Fogyasztas = fogyasztas;
        }
    }
}
