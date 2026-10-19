using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Receptek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string>osszetevok=new List<string>();
            osszetevok.Add("csirke");
            osszetevok.Add("tejföl");
            osszetevok.Add("só");
            osszetevok.Add("bors");
            Recept recept1 = new Recept("Elso", osszetevok, 45, "2023.06.15");
            recept1.HozzavalokListazasa();
            Console.WriteLine(recept1.AllergenekEllenorzese());
        }
    }
}
