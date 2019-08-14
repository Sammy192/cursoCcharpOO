using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exer2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int[] numeros = new int[num];

            string[] vetAux = Console.ReadLine().Split(' ');

            for (int i=0; i<num; i++)
            {
                numeros[i] = int.Parse(vetAux[i]);
            }


            int contadorPar = 0;
            for (int i=0; i<num;i++)
            {
                if (numeros[i] % 2 == 0)
                {
                    Console.Write(numeros[i] + " ");
                    contadorPar = contadorPar + 1;
                }
            }

            Console.WriteLine();
            Console.WriteLine(contadorPar);
            Console.ReadLine();

        }
    }
}
