using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exer1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] entrada = Console.ReadLine().Split(' ');

            int linha = int.Parse(entrada[0]);
            int coluna = int.Parse(entrada[1]);
            int[,] matrizDados = new int[linha,coluna];

            for (int l=0; l< linha;l++)
            {
                string[] entradaAux =  Console.ReadLine().Split(' ');
                for (int c=0;c<coluna;c++)
                {
                    matrizDados[l, c] = int.Parse(entradaAux[c]); 
                }
            }

            for (int l=0; l< linha;l++)
            {
                for (int c=0;c<coluna;c++)
                {
                    Console.Write(matrizDados[l,c] +  " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
