using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri1067
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;

            x = int.Parse(Console.ReadLine());

            for (int i=0; i <= x; i++)
            {
                if ( i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadLine();




        }
    }
}
