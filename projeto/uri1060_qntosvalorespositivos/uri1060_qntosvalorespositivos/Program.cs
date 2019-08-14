using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri1060_qntosvalorespositivos
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, n4, n5, n6, numeroPositivo;

            n1 = double.Parse(Console.ReadLine());
            n2 = double.Parse(Console.ReadLine());
            n3 = double.Parse(Console.ReadLine());
            n4 = double.Parse(Console.ReadLine());
            n5 = double.Parse(Console.ReadLine());
            n6 = double.Parse(Console.ReadLine());

            numeroPositivo = 0;
            if (n1 > 0)
            {
                numeroPositivo = numeroPositivo + 1;
            }
            if (n2 > 0)
            {
                numeroPositivo = numeroPositivo + 1;
            }
            if (n3 > 0)
            {
                numeroPositivo = numeroPositivo + 1;
            }
            if (n4 > 0)
            {
                numeroPositivo = numeroPositivo + 1;
            }
            if (n5 > 0)
            {
                numeroPositivo = numeroPositivo + 1;
            }
            if (n6 > 0)
            {
                numeroPositivo = numeroPositivo + 1;
            }

            Console.WriteLine(numeroPositivo + " valores positivos");

            Console.ReadLine();



        }
    }
}
