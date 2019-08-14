using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri1101
{
    class Program
    {
        static void Main(string[] args)
        {

            int x, y, menor, maior,soma;

            string[] vet = Console.ReadLine().Split(' ');
            x = int.Parse(vet[0]);
            y = int.Parse(vet[1]);

            while(x > 0 && y > 0)
            {
                maior = x;
                menor = y;
                if (x < y)
                {
                    maior = y;
                    menor = x;
                }
                soma = 0;
                for (int i = menor; i <= maior;i++)
                {
                    soma = i + soma;
                    Console.Write(i + " ");
                    
                }
                Console.WriteLine("Sum="+ soma);

                vet = Console.ReadLine().Split(' ');
                x = int.Parse(vet[0]);
                y = int.Parse(vet[1]);

            } 
            Console.ReadLine();
        }
    }
}
