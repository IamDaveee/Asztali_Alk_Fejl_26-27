using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Receptek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Recept recept1 = new Recept("Csirkepaprikás", new List<string> { "csirke", "tejföl", "só", "bors" }, 45, new DateTime(2023, 06, 15));
                Recept recept2 = new Recept("Gyümölcssaláta", new List<string> { "alma", "banán", "narancs" });
                Recept recept3 = new Recept("Üres Recept");

                VegetarianusRecept vegRec1 = new VegetarianusRecept("Zöldségleves", new List<string> { "répa", "zeller", "burgonya" }, 20, new DateTime(2025, 09, 20), 250);
                VegetarianusRecept vegRec2 = new VegetarianusRecept("VegánBurger", new List<string> { "bab", "rizs", "glutén" }, 400);

                HusosRecept husRec1 = new HusosRecept("Marhapörkölt", new List<string> { "marha", "hagyma", "paprika" }, "marha", 200);
                HusosRecept husRec2 = new HusosRecept("Halászlé", new List<string> { "hal", "paprika", "só" }, "hal", 180);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
