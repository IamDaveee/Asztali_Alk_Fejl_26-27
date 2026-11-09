using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otthoni_11._08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Recept r1 = new Recept("Csirkepaprikás", new List<string>() { "csirke", "paprika", "tejföl", "só", "bors", "glutén", "tej" }, 45, Convert.ToDateTime("2023.06.15"));
                VegetarianusRecept v1 = new VegetarianusRecept("Zöldségleves", new List<string>() { "répa", "zeller" }, 50, new DateTime(2025, 09, 20), 250);
                HusosRecept h1 = new HusosRecept("Marhapörkölt", new List<string>() { "marha", "hagyma" }, "marha", 200);

                Console.WriteLine(r1.AllergenekEllenorzese());
                Console.WriteLine();
                Console.WriteLine(h1.HozzavalokListazasa());

            }
            catch (Exception e)
            {
                Console.WriteLine($"Hiba: {e.Message}");
            }
        }
    }
}
