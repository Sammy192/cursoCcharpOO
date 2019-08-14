using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace uri1155
{
    class Program
    {
        static void Main(string[] args)
        {
            double contador = 0;

            for (float i = 1; i <= 100; i++)

            {

                contador += 1 / i;

            }

            Console.WriteLine(contador.ToString("F2",CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}
