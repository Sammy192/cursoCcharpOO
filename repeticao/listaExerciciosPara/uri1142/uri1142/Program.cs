using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri1142
{
    class Program
    {
        static void Main(string[] args)
        {
            int repeticao = int.Parse(Console.ReadLine());
            int aux = 0;
            for (int linha= 0; linha < repeticao; linha ++ )
            {
                for (int coluna=1; coluna <=4; coluna++)
                {
                    aux = aux + 1;

                    if (coluna == 4)
                    {                        
                        Console.WriteLine("PUM");
                    }
                    else
                    {
                        Console.Write(aux + " ");
                    }                    
                }                
            }

            Console.ReadLine();

        }
    }
}
