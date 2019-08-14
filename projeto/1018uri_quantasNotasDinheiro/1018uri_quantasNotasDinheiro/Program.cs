using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _1018uri_quantasNotasDinheiro
{
    class Program
    {
        static void Main(string[] args)
        {
            int nota100, nota50, nota20, nota10, nota5, nota2, nota1, valorPedido,resto;

            valorPedido = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            nota100 = valorPedido / 100;
            resto = valorPedido % 100;

            nota50 = resto / 50;
            resto = resto % 50;

            nota20 = resto / 20;
            resto = resto % 20;

            nota10 = resto / 10;
            resto = resto % 10;

            nota5 = resto / 5;
            resto = resto % 5;

            nota2 = resto / 2;
            resto = resto % 2;

            nota1 = resto / 1;
            resto = resto % 1;

            /*ou poderia ser assim
            cem = N / 100;
            resto = N % 100;
            cinquenta = resto / 50;
            vinte = ((resto % 50) / 20);
            dez = (((resto % 50) % 20) / 10);
            cinco = (((resto % 50) % 20) % 10) / 5;
            dois = (((((resto % 50) % 20) % 10) % 5) / 2);
            um = ((((((resto % 50) % 20) % 10) % 5) % 2) / 1);
            fimpoderia */

            Console.WriteLine(valorPedido);
            Console.WriteLine(nota100 +" nota(s) de R$ 100,00");
            Console.WriteLine(nota50 + " nota(s) de R$ 50,00");
            Console.WriteLine(nota20 + " nota(s) de R$ 20,00");
            Console.WriteLine(nota10 + " nota(s) de R$ 10,00");
            Console.WriteLine(nota5 + " nota(s) de R$ 5,00");
            Console.WriteLine(nota2 + " nota(s) de R$ 2,00");
            Console.WriteLine(nota1 + " nota(s) de R$ 1,00");

            Console.ReadLine();        

        }
    }
}
