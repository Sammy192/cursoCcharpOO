using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplo2
{
    class Program
    {
        static void Main(string[] args)
        {
            int linha, coluna;

            string[] tamanhaMatriz = Console.ReadLine().Split(' ');
            linha = int.Parse(tamanhaMatriz[0]);
            coluna = int.Parse(tamanhaMatriz[1]);

            int[,] mat = new int [linha, coluna];

            for (int l=0; l<linha;l++)
            {
                string[] entradaDados = Console.ReadLine().Split(' ');
                for (int c=0;c<coluna;c++)
                {
                    mat[l, c] = int.Parse(entradaDados[c]);
                }
            }

            int[] vet = new int[linha];

            for (int l=0;l<linha;l++)
            {
                int soma = 0;
                for (int c=0; c<coluna;c++)
                {
                    soma = soma + mat[l, c];
                }
                vet[l] = soma;
                //Console.WriteLine(vet[l]);
            }

            for (int i = 0; i<linha;i++)
            {
                Console.WriteLine(vet[i]);
            }


            Console.ReadLine();
        }
    }
}
