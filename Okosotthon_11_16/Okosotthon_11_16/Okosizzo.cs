using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Gyak20261116Projekt
{
    internal class Okosizzo:Okoseszkoz
    {
        int fenyero;

        public int Fenyero
        {
            get => fenyero;
            set 
            {
                if (value<0 ||value>100)
                {
                    throw new Exception("Hiba a fényerő 0 és 100 között kell legyen");
                }
                else
                {
                    fenyero = value;
                }


            }
        
        }

        public Okosizzo(string tipus, int id, bool bekapcsolt, int fogyasztas, int fenyero) : base(tipus, id, bekapcsolt, fogyasztas)
        {
           Fenyero= fenyero;
        }

        


        public void FenyeroAllit()
        {
            Console.WriteLine("Add meg a fényerő értékét 0 és 100 között");
            int ujFenyero = Convert.ToInt32(Console.ReadLine());
           

            if (ujFenyero>-1||ujFenyero<101)
            {
               fenyero = ujFenyero;
            }
            else
            {
                Console.WriteLine("Hiba a fényerő 0 és 100 között kell legyen");
            }


        }
        public override string AktualE()
        {
            int ossz = 0;
            if (Bekapcsolt == false)
            {
                Fogyasztas = 0;
            }
            else
            {
                ossz = Fogyasztas * Fenyero * 100;
                Fogyasztas = ossz;
            }

            return $"{Fogyasztas}W";
            

        }
        public override string Diag()
        {
            return $"Aktuális fényerő: {Fenyero}%,Aktuális Fogyasztás: {Fogyasztas}W ";

        }
    }
}
