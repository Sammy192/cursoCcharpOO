using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri1074
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, repeticao;

            repeticao = int.Parse(Console.ReadLine());

            for (int i=0; i < repeticao; i++)
            {
                num = int.Parse(Console.ReadLine());
                if (num != 0)
                {
                    if (num % 2 == 0)
                    {
                        Console.Write("EVEN ");
                    }
                    else
                    {
                        Console.Write("ODD ");
                    }

                    if (num > 0)
                    {
                        Console.WriteLine("POSITIVE");
                    }
                    else
                    {
                        Console.WriteLine("NEGATIVE");
                    }
                }else              
                {
                    Console.WriteLine("NULL");
                }
            }
            Console.ReadLine();
        }
    }
}
