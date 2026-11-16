using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okosotthon_11_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
			try
			{
                Okosredony alma = new Okosredony("x", 1, true, 100, 140, 100);
            }
			catch (Exception x)
			{
                Console.WriteLine(x.Message);
			}
        }
    }
}
