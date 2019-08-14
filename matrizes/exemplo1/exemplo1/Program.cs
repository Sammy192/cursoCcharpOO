using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] a = new int[n, n];

            for (int i=0; i<n;i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for (int j=0;j <n;j++)
                {
                    a[i, j] = int.Parse(s[j]);
                }
            }

            Console.WriteLine("DIAGONAL PRINCIPAL: ");
            for (int i=0; i<n;i++)
            {
                Console.Write(a[i,i] + " ");
            }
            Console.WriteLine();

            int cont = 0;
            for (int i=0;i< n;i++){
                for (int j=0; j<n;j++){
                    if (a[i,j] < 0)
                    {
                        cont++;
                    }
                }
            }
            Console.WriteLine("quantidade de negativos= "+cont);

            Console.ReadLine();
        }
    }
}
