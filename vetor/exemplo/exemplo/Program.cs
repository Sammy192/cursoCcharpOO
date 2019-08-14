using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            int repeticao = int.Parse(Console.ReadLine());
            double[] vet;
            vet = new double[repeticao];

            for (int i = 0; i < repeticao; i++)
            {
                vet[i] = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            }

            for (int i=0; i <repeticao; i++)
            {
                Console.WriteLine(vet[i].ToString("F1", CultureInfo.InvariantCulture));
            }

            Console.ReadLine();

        }
    }
}
