using System;
using System.Globalization;

namespace exer4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            double[] valores = new double[num];

            string[] entradaDados = Console.ReadLine().Split(' ');
            for (int i = 0; i < num; i++)
            {
                valores[i] = double.Parse(entradaDados[i],CultureInfo.InvariantCulture);
            }

            double soma = 0.0;
            for (int i=0; i <num; i++)
            {
                soma = soma + valores[i];
            }

            double media = soma / num;
            Console.WriteLine(media.ToString("F3",CultureInfo.InvariantCulture));

            for (int i = 0; i <num; i++)
            {
                if (valores[i] < media)
                {
                    Console.WriteLine(valores[i].ToString("F1",CultureInfo.InvariantCulture));
                }
            }


            Console.ReadLine();
        }
    }
}
