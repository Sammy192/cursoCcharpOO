using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri1099
{
    class Program
    {
        static void Main(string[] args)
        {
            //int repeticao,x,y,menor, maior,soma;

            int repeticao = int.Parse(Console.ReadLine());
            
            for (int i =0; i < repeticao;i++)
            {
                int soma = 0;
                string[] vet = Console.ReadLine().Split(' ');
                int x = int.Parse(vet[0]);
                int y = int.Parse(vet[1]);

                int menor = x;
                int maior = y;
                if (x > y)
                {
                    menor = y;
                    maior = x;
                }
                
                for (int cont= menor +1; cont < maior; cont++)
                {
                    if (cont % 2 != 0)
                    {
                        soma = soma + cont;
                    }
                }
                Console.WriteLine(soma);
            }
            Console.ReadLine();
        }
    }
}
