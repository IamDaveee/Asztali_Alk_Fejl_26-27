using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Öröklődés_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
			try
			{
                Jarmu jarmu1 = new Jarmu("Ford", "Mustang", 1967);
                Console.WriteLine(jarmu1.Megjelenit());
                Console.WriteLine();
                Jarmu jarmu2 = new Jarmu("Tesla", "Model S");
                Console.WriteLine(jarmu2.Megjelenit());
                Console.WriteLine();

                Auto auto1 = new Auto("Audi", "A6", 2020, 4);
                Console.WriteLine(auto1.Megjelenit());
                Console.WriteLine();
                Auto auto2 = new Auto("Fiat", "Panda", 1);
                Console.WriteLine(auto2.Megjelenit());
                Console.WriteLine();

                Motor motor1 = new Motor("Yamaha", "MT-07", 2018, 2, "naked bike");
                Console.WriteLine(motor1.Megjelenit());
                Console.WriteLine();
                Motor motor2 = new Motor("Suzuki", "GSX-R1000", 4, "sport");
                Console.WriteLine(motor2.Megjelenit());
                Console.WriteLine();
            }
			catch (Exception ex)
			{
                Console.WriteLine(ex.Message);
			}
        }
    }
}
