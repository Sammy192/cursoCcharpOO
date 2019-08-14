using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace uri1060_qntosvalorespositivos
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, n4, n5, n6, numeroPositivo,soma,media;

            n1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            n3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            n4 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            n5 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            n6 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            numeroPositivo = 0;
            soma = 0;
            if (n1 > 0)
            {
                numeroPositivo = numeroPositivo + 1;
                soma = soma + n1;
            }
            if (n2 > 0)
            {
                numeroPositivo = numeroPositivo + 1;
                soma = soma + n2;
            }
            if (n3 > 0)
            {
                numeroPositivo = numeroPositivo + 1;
                soma = soma + n3;
            }
            if (n4 > 0)
            {
                numeroPositivo = numeroPositivo + 1;
                soma = soma + n4;
            }
            if (n5 > 0)
            {
                numeroPositivo = numeroPositivo + 1;
                soma = soma + n5;
            }
            if (n6 > 0)
            {
                numeroPositivo = numeroPositivo + 1;
                soma = soma + n6;
            }
            media = (soma / numeroPositivo);
            Console.WriteLine(numeroPositivo + " valores positivos");
            Console.WriteLine(media.ToString("F1",CultureInfo.InvariantCulture));

            Console.ReadLine();



        }
    }
}
