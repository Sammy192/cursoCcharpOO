using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace uri1065
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, n4, n5, numeroPar;

            n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            n3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            n4 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            n5 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            numeroPar = 0;

            if (n1 % 2 == 0)
            {
                numeroPar = numeroPar + 1;

            }
            if (n2 % 2 == 0)
            {
                numeroPar = numeroPar + 1;

            }
            if (n3 % 2 == 0)
            {
                numeroPar = numeroPar + 1;

            }
            if (n4 % 2 == 0)
            {
                numeroPar = numeroPar + 1;

            }
            if (n5 % 2 == 0)
            {
                numeroPar = numeroPar + 1;

            }
            
            Console.WriteLine(numeroPar + " valores pares");
            

            Console.ReadLine();


        }
    }
}
