using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri1096
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, a, b, c, d;
            x = 5;
            b = 7;
            c = 6;
            d = 5;
            a = 1;
            for (int i = 1; i <= x; i++)
            {
                if (a % 2 != 0)
                {
                    Console.WriteLine("I=" + a + " J=" + b);
                    Console.WriteLine("I=" + a + " J=" + c);
                    Console.WriteLine("I=" + a + " J=" + d);
                    a++;
                }
                else
                {
                    a++;
                    i--;
                }
            }

            Console.ReadLine();

        }
    }
}
