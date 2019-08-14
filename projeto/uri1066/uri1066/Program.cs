using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri1066
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, count_Impar = 0, count_Par = 0, count_Neg = 0, count_Pos = 0, i;
            for (i = 0; i < 5; i++)
            {
                X = int.Parse(Console.ReadLine());
                if (X % 2 == 0)
                {
                    count_Par++;
                }
                else
                {
                    count_Impar++;
                }
                if (X > 0)
                {
                    count_Pos++;
                }
                else if (X != 0)
                {
                    count_Neg++;
                }
            }
            Console.WriteLine(count_Par + " valor(es) par(es)");
            Console.WriteLine(count_Impar + " valor(es) impar(es)");
            Console.WriteLine(count_Pos + " valor(es) positivo(s)");
            Console.WriteLine(count_Neg + " valor(es) negativo(s)");
            Console.ReadLine();
        }

    }
 }

