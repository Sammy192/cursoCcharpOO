using System;
using System.Globalization;

namespace exer1
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = int.Parse(Console.ReadLine());

            double[] numeros = new double[num];

            string[] aux = Console.ReadLine().Split(' ');
            for (int i = 0; i < num; i++)
            {                
                numeros[i] = double.Parse(aux[i], CultureInfo.InvariantCulture);
            }

            double maior = numeros[0];
            int posicaoElementoMaior = 0;

            for (int i=1; i < num; i++)
            {
                if (numeros[i] > maior)
                {
                    maior = numeros[i];
                    posicaoElementoMaior = i;
                }
            }

            Console.WriteLine(maior.ToString("F1",CultureInfo.InvariantCulture));
            Console.WriteLine(posicaoElementoMaior);

            Console.ReadLine();


        }
    }
}
