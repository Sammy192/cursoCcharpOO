using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace areaRaio
{
    class Program
    {
        static void Main(string[] args)
        {
            double area, raio, n;
            n = 3.14159;
           
            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = (n * (Math.Pow(raio,2.0)));
            //area = 3.14159 * raio * raio;
            Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}
