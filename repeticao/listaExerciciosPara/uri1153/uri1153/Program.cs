using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri1153fatorialSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());


            int fatorial = 1;
            //int fatorial = 0;
            //int anterior = 1;
            for (int i=1; i <= num; i++)
            {
                fatorial = i * fatorial;
                //anterior = fatorial;

            }

            Console.WriteLine(fatorial);

            Console.ReadLine();

        }
    }
}
