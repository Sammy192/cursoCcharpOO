using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri1158
{
    class Program
    {
        static void Main(string[] args)
        {
            int repeticao = int.Parse(Console.ReadLine());
            int x, y,soma,contaImpar;

            
            for (int i=0; i < repeticao;i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                x = int.Parse(vet[0]);
                y = int.Parse(vet[1]);

                soma = 0;
                contaImpar = 0;
                for (int aux=x; contaImpar < y; aux++ )
                {
                    if (aux % 2 != 0)
                    {
                        contaImpar = contaImpar + 1;
                        soma = soma + aux;
                    }
                }

                Console.WriteLine(soma);

            }
            Console.ReadLine();
        }
    }
}
