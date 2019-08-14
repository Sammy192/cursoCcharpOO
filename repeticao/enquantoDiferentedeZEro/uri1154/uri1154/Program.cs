using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace uri1154
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;
            int soma = 0;
            double media = 0.0;
            int idade = 0;

            idade = int.Parse(Console.ReadLine());

            while (idade > 0)
            {               
                soma = soma + idade;
                cont = cont + 1;
                idade = int.Parse(Console.ReadLine());
            }
            media = (double) soma / cont;
            Console.WriteLine(media.ToString("F2",CultureInfo.InvariantCulture));

            Console.ReadLine();

        }
    }
}
