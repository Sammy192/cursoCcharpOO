using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o tamanha da matriz: (linha,coluna)");
            string[] entrada = Console.ReadLine().Split(' ');

            int linha = int.Parse(entrada[0]);
            int coluna = int.Parse(entrada[1]);
            int[,] matrizDados = new int[linha, coluna];

            for (int l = 0; l < linha; l++)
            {
                
                for (int c = 0; c < coluna; c++)
                {
                    Console.WriteLine("Digite o valor para a posicao: "+ l + "-" + c);
                    matrizDados[l,c]= int.Parse(Console.ReadLine());
                    //matrizDados[l, c] = int.Parse(entradaAux[c]);
                }
            }

            for (int l = 0; l < linha; l++)
            {
                for (int c = 0; c < coluna; c++)
                {
                    Console.Write(matrizDados[l, c] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
