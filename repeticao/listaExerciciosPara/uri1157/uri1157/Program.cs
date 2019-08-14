using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri1157
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for ( int i=1; i<= num; i++)
            {
                if (num % i ==0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadLine();
        }
    }
}
