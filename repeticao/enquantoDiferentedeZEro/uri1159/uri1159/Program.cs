using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri1159
{
    class Program
    {
        static void Main(string[] args)
        {
            int num,aux,soma;

            num = int.Parse(Console.ReadLine());
            soma = 0;
            aux = 0;

            while (num != 0 )
            {
                while (aux != 5)
                {
                    if (num % 2 == 0)
                    {
                        soma = soma + num;
                        aux = aux + 1;
                    }
                 num = num + 1;
                }
                Console.WriteLine(soma);
                num = int.Parse(Console.ReadLine());
                soma = 0;
                aux = 0;
            }           
            Console.ReadLine();
        }
    }
}
