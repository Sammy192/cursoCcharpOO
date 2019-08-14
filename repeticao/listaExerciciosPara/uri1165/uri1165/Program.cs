using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri1165ehOunaoPrimo
{
    class Program
    {
        static void Main(string[] args)
        {
            int repetir = int.Parse(Console.ReadLine());
            int contador=0;

            for (int j=0; j < repetir; j++) {

                int num = int.Parse(Console.ReadLine());

                
                for (int i = 1; i <= num; i++)
                {
                    
                    if (num % i == 0)
                    {
                        contador = contador + 1;
                    }
                }

                if (contador == 2)
                {
                    Console.WriteLine(num + " eh primo");
                }
                else
                {
                    Console.WriteLine(num + " nao eh primo");
                }
                contador = 0;
            }


            Console.ReadLine();

        }
    }
}
