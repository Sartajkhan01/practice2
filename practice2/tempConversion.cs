using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice2
{
    public class tempConversion
    {

        public static void Conversion()
        {
            double fahrenheit;
            double celcius = 36;
            Console.WriteLine("Celcius:" + celcius);
            fahrenheit = (celcius * 9) / 5 + 32;
            Console.WriteLine("Fahrenheit:" + fahrenheit);
            Console.ReadLine();
        }
    }
}
