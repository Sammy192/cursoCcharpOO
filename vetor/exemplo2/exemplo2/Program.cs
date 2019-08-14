using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplo2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] vet;
            vet = new int[n];

            string[] s = Console.ReadLine().Split(' ');
            for (int i=0; i<n; i++)
            {
                vet[i] = int.Parse(s[i]);
            }

            for (int i=0; i <n;i++)
            {
                if (vet[i] < 0 )
                {
                    Console.WriteLine(vet[i]);
                }
            }


            Console.ReadLine();

        }
    }
}
