using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace minutosApagar
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutosConsumidos;
            double conta;

            minutosConsumidos = int.Parse(Console.ReadLine());

            conta = 50.0;

            if (minutosConsumidos > 100)
            {
                //conta = conta + (minutosConsumidos - 100) * 2.0;
                conta += (minutosConsumidos - 100) * 2.0;
            }

            Console.WriteLine("Valor a pagar: R$ " + conta.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}
