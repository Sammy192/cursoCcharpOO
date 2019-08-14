using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exer3lista
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int[,] mat = new int[num,num];

            for (int l=0; l<num;l++)
            {
                string[] aux = Console.ReadLine().Split(' ');
                for (int c=0;c<num;c++)
                {
                    mat[l, c] = int.Parse(aux[c]);
                }
            }

            //int maior = 0;
            for (int l = 0; l < num; l++)
            {
                int maior = mat[l, 0];
                for (int c = 0; c < num; c++)
                {
                    if (mat[l, c] > maior)
                    {
                        maior = mat[l, c];                        
                    }
                }
                Console.WriteLine(maior);
                //maior = 0;
            }

            Console.ReadLine();
        }
    }
}
