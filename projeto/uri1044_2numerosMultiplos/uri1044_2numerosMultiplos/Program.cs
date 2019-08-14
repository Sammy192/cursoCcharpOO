using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri1044_2numerosMultiplos
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;

            string[] vet = Console.ReadLine().Split(' ');

            n1 = int.Parse(vet[0]);
            n2 = int.Parse(vet[1]);

            //resto = n2 % n1;
            if ( (n2 % n1 == 0) | (n1 % n2 == 0 ))
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }

            Console.ReadLine();


        }
    }
}
