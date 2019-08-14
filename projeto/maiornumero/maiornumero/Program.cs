using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _1012URI
{
    class Program
    {
        static void Main(string[] args)
        {

            int n1, n2, n3, maiorN1N2,maiorN1N2N3;
            string[] vet;
            vet = Console.ReadLine().Split(' ');

            n1 = int.Parse(vet[0], CultureInfo.InvariantCulture);
            n2 = int.Parse(vet[1], CultureInfo.InvariantCulture);
            n3 = int.Parse(vet[2], CultureInfo.InvariantCulture);

           
            maiorN1N2 = (n1 + n2 + Math.Abs(n1 - n2)) / 2;
            maiorN1N2N3 = (maiorN1N2 + n3 + Math.Abs(maiorN1N2 - n3)) / 2;

            Console.WriteLine(maiorN1N2N3 + " eh o maior");

            Console.ReadLine();

        }
    }
}
