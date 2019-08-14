using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exer3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numElementosVetor = int.Parse(Console.ReadLine());
            int[] vetValoresA = new int[numElementosVetor];
            int[] vetValoresB = new int[numElementosVetor];
            int[] vetValoresC = new int[numElementosVetor];

            //inicio forma 1
            //lendo vetor A e convertendo para int
            string[] auxA = Console.ReadLine().Split(' ');
            for (int i = 0; i < numElementosVetor; i++)
            {              
                
                vetValoresA[i] = int.Parse(auxA[i]);
                
            }
            //fim leitura vetor a

            //lendo vetor B e convertendo para int
            string[] auxB = Console.ReadLine().Split(' ');
            for (int i =0; i <numElementosVetor;i++)
            {
                vetValoresB[i] = int.Parse(auxB[i]);
            }
            //fim leitura vetor b

            //somando vetor a+b em c
            for (int i = 0; i < numElementosVetor; i++)
            {
                vetValoresC[i] = vetValoresA[i] + vetValoresB[i];
                Console.Write(vetValoresC[i] + " ");
            }
            //fim forma 1
            Console.WriteLine();



            /* caso queira exibir cada vetor em separado 
             * for (int i=0; i <numElementosVetor; i++)
             {
                 Console.Write(vetValoresA[i] + " ");

             }
             Console.WriteLine();
             for (int i = 0; i < numElementosVetor; i++)
             {
                 Console.Write(vetValoesB[i] + " ");

             }*/


            Console.ReadLine();
        }
    }
}
