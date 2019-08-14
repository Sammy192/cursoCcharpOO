using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri1078
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = int.Parse(Console.ReadLine());

            for (int i=1; i <=10; i++)
            {
                int resultado = i * n;
                Console.WriteLine(i+" x " + n + " = "+ resultado);

            }

            Console.ReadLine();
        }
    }
}
