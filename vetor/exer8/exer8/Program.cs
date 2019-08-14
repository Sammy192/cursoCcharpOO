using System;
using System.Globalization;

namespace exer8
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            double[] alturas = new double[num];
            char[] sexo = new char[num];
            int contadorMulher=0; int contadorHomem = 0;

            for (int i=0; i<num; i++)
            {
                string[] entradaDados = Console.ReadLine().Split(' ');
                alturas[i] = double.Parse(entradaDados[0], CultureInfo.InvariantCulture);
                sexo[i] = char.Parse(entradaDados[1]);
            }

            //VER MAIOR ALTURA
            double maior = 0.0;
            for (int i=0; i <num; i++)
            {
                if (alturas[i] > maior)
                {
                    maior = alturas[i];
                }
            }
            //VER MENOR ALTURA
            double menor = maior;
            for (int i = 0; i < num; i++)
            {
                if (alturas[i] < menor)
                {
                    menor = alturas[i];
                }
            }

            Console.WriteLine("Menor altura = " + menor.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Maior altura = " + maior.ToString("F2",CultureInfo.InvariantCulture));

            double media = 0.0;
            double soma = 0.0;
            for (int i = 0; i < num; i++)
            {
                if (sexo[i] == 'F')
                {
                   soma =soma +  alturas[i];
                    contadorMulher = contadorMulher + 1;
                }
                else
                {
                    contadorHomem++;
                }
            }


            if (contadorMulher == 0)
            {
                Console.WriteLine("Nao ha nenhuma mulher dentre as pessoas");
            }
            else
            {
                media = (double)soma / contadorMulher;
                Console.WriteLine("Media das alturas das mulheres = " + media.ToString("F2", CultureInfo.InvariantCulture));
            }

            if (contadorHomem == 0)
            {
                Console.WriteLine("Nao ha nenhum homem dentre as pessoas");
            }
            else
            {
                Console.WriteLine("Numero de homens = " + contadorHomem);
            }
            
            /*
            //soh mostrar na tela os dois vetores
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(alturas[i] + " " + sexo[i]);
            }*/



            Console.ReadLine();
        }
    }
}
