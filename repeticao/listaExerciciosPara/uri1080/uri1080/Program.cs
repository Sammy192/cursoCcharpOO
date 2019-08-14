using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri1080
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, num,maior,posicao;
            num = 0;
            maior = 0;
            posicao = 0;
            
            for (i=1; i <= 100; i++)
            {
                num = int.Parse(Console.ReadLine());

                if ( num > maior)
                {
                    maior = num;
                    posicao = i;
                }

            }

            //Console.WriteLine();
            Console.WriteLine(maior);
            Console.WriteLine(posicao);

            Console.ReadLine();
        }
    }
}
