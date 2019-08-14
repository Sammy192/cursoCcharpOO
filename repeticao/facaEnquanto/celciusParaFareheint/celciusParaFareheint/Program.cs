using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace celciusParaFareheint
{
    class Program
    {
        static void Main(string[] args)
        {
            double celsius, faren;
            char op;

            do {
                Console.WriteLine("Digite a temperatura em Celsius: ");
                celsius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                faren = 9.0 * celsius / 5.0 + 32;
                Console.WriteLine("Equivalente em Fahrenheit " + faren.ToString("F1", CultureInfo.InvariantCulture));
                Console.Write("Deseja repetir (s/n)?");
                op = char.Parse(Console.ReadLine());
            } while (op == 's');



            Console.ReadLine();




        }
    }
}
