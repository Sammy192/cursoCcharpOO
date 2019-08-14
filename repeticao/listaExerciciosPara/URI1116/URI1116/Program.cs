using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace URI1116
{
    class Program
    {
        static void Main(string[] args)
        {
            int repeticao, n1, n2;
            double div;

            repeticao = int.Parse(Console.ReadLine());

            for (int i =0; i < repeticao; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                n1 = int.Parse(vet[0]);
                n2 = int.Parse(vet[1]);

                if (n2 == 0 )
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    div =(double) n1 / n2;
                    Console.WriteLine(div.ToString("F1",CultureInfo.InvariantCulture));
                }
            }
            Console.ReadLine();



        }
    }
}
