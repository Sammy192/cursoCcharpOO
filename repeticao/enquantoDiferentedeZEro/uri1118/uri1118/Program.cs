using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace uri1117
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, media;
            int op;

            op = 1;
            while (op != 2)
            {
                media = 0.0;
                n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                while (n1 < 0.0 || n1 > 10.0)
                {
                    Console.WriteLine("nota invalida");
                    n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }

                n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                while (n2 < 0.0 || n2 > 10.0)
                {
                    Console.WriteLine("nota invalida");
                    n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }

                media = (n1 + n2) / 2.0;
                Console.WriteLine("media = " + media.ToString("F2", CultureInfo.InvariantCulture));

                Console.WriteLine("novo calculo (1-sim 2-nao)");
                op = int.Parse(Console.ReadLine());

                while (op != 1 && op != 2)
                {
                    Console.WriteLine("novo calculo (1-sim 2-nao)");
                    op = int.Parse(Console.ReadLine());
                }

            }
            Console.ReadLine();
        }
    }
}
