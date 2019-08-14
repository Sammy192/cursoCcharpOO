using System;
using System.Globalization;

namespace exer1lista
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            double[,] vet = new double[num, num];

            for (int l=0; l<num; l++)
            {
                string[] entradaDados = Console.ReadLine().Split(' ');
                for (int c=0; c<num;c++)
                {
                    vet[l, c] = double.Parse(entradaDados[c],CultureInfo.InvariantCulture);
                }
            }

            double somaElementosPositivos = 0.0;

            for (int l=0; l<num;l++)
            {
                for (int c=0; c<num; c++)
                {
                    if (vet[l,c] > 0.0)
                    {
                        somaElementosPositivos = somaElementosPositivos + vet[l,c];
                    }
                }
            }
            Console.WriteLine("SOMA DOS POSITIVOS:" + somaElementosPositivos.ToString("F1",CultureInfo.InvariantCulture));

            int entradaLinhaEscolhida = int.Parse(Console.ReadLine());

            Console.Write("LINHA ESCOLHIDA: ");

                for (int c=0; c<num; c++)
                {
                    Console.Write(vet[entradaLinhaEscolhida,c].ToString("F1",CultureInfo.InvariantCulture) + " ");
                }

            Console.WriteLine();
            //ELEMENTOS DA COLUNA ESCOLHIDA

            int entradaColunaEscolhida = int.Parse(Console.ReadLine());

            Console.Write("COLUNA ESCOLHIDA: ");
            for (int l = 0; l< num; l++)
            {
                Console.Write(vet[l, entradaColunaEscolhida].ToString("F1", CultureInfo.InvariantCulture) + " ");
            }

            Console.WriteLine();
            //fim elementos da coluna escolhida

            //exibir a diagonal principal
            Console.Write("DIAGONAL PRINCIPAL: ");
            for (int l=0; l<num;l++)
            {
                    Console.Write(vet[l,l].ToString("F1",CultureInfo.InvariantCulture) + " ");                
            }
            Console.WriteLine();
            //fim exibir diagonal principal

            for (int l=0; l<num; l++)
            {
                for (int c=0; c<num; c++)
                {
                    if (vet[l,c] < 0.0) {
                        vet[l, c] = Math.Pow(vet[l, c], 2);
                    }
                    Console.Write(vet[l,c].ToString("F1",CultureInfo.InvariantCulture) + " ");
                }
                Console.WriteLine();
            }


            Console.ReadLine();
        }
    }
}
