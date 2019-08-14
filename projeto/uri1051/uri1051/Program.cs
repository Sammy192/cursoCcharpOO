using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace uri1051
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor;
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (valor > 0.00 && valor <= 2000.00)
            {
                Console.WriteLine("Isento");
            }
            else if (valor > 2000.00 && valor <= 3000.00)
            {
                Console.WriteLine("R$ " + (((valor - 2000.00) * 0.08).ToString("F2", CultureInfo.InvariantCulture)));
            }
            else if (valor > 3000.00 && valor <= 4500.00)
            {
                Console.WriteLine("R$ " + ((1000.00 * 0.08) + ((valor - 3000.00) * 0.18)).ToString("F2", CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine("R$ " + ((1000.00 * 0.08) + (1500.00 * 0.18) + ((valor - 4500.00) * 0.28)).ToString("F2", CultureInfo.InvariantCulture));
            }

            Console.ReadLine();

        }
    }
}
