using System;
using System.Globalization;

namespace exer7
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            string[] nomes = new string[num];
            double[] notaPrimeiroSem = new double[num];
            double[] notaSegundoSem = new double[num];

            string[] alunosAprovados = new string[num];

            for (int i = 0; i < num; i++)
            {
                string[] aux = Console.ReadLine().Split(' ');
                nomes[i] = aux[0];
                notaPrimeiroSem[i] = double.Parse(aux[1], CultureInfo.InvariantCulture);
                notaSegundoSem[i] = double.Parse(aux[2], CultureInfo.InvariantCulture);
            }


            Console.WriteLine("Alunos aprovados:");
           
            for (int i=0; i <num; i++)
            {
                double media =(notaPrimeiroSem[i] + notaSegundoSem[i]) / 2.0;
                if (media >= 6.0)
                {
                    Console.WriteLine(nomes[i]);
                }
            }

            Console.ReadLine();
        }
    }
}
