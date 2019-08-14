using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exer2lista
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] aux = Console.ReadLine().Split(' ');
            int linha = int.Parse(aux[0]);
            int coluna = int.Parse(aux[1]);

            int[,] matA = new int[linha,coluna];
            int[,] matB = new int[linha, coluna];
            int[,] matc = new int[linha, coluna];

            //entrada mat a
            for (int l=0; l<linha;l++)
            {
                aux = Console.ReadLine().Split(' ');
                for (int c=0; c<coluna;c++)
                {
                    matA[l, c] = int.Parse(aux[c]);
                }
            }

            //entrada mat b
            for (int l = 0; l < linha; l++)
            {
                aux = Console.ReadLine().Split(' ');
                for (int c = 0; c < coluna; c++)
                {
                    matB[l, c] = int.Parse(aux[c]);
                }
            }

            //soma mat a + mat b e impressao da matc
            for (int l = 0; l < linha; l++)
            {                
                for (int c = 0; c < coluna; c++)
                {
                    matc[l, c] = matA[l,c] + matB[l,c];
                    Console.Write(matc[l,c] + " ");
                }
                Console.WriteLine();
            }





            Console.ReadLine();
        }
    }
}
