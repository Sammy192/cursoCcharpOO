using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace uri1043
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, p, A;
            String[] vet = Console.ReadLine().Split(' ');

            a = double.Parse(vet[0], CultureInfo.InvariantCulture);
            b = double.Parse(vet[1], CultureInfo.InvariantCulture);
            c = double.Parse(vet[2], CultureInfo.InvariantCulture);
            //6.0 4.0 2.0
            //6.0 4.0 2.1 ok
            if ((a > Math.Abs(b - c)) & (a < b + c) | (b > Math.Abs(a - c)) & (b < a + c) | (c > Math.Abs(a - b)) & (c < a + b))
            {
                p = a + b + c;  
                Console.WriteLine("Perimetro = " + p.ToString("F1", CultureInfo.InvariantCulture));
            }
            else
            {
                A = (c * (a + b)) / 2;
                Console.WriteLine("Area = " + A.ToString("F1", CultureInfo.InvariantCulture));
            }
            Console.ReadLine();
        }
    }
}
