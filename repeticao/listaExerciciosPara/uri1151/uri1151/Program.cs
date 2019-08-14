using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri1151Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int primeiroTermo = 0;
            int segundoTermo = 1;
            int novo;

            novo = 0;

            Console.Write(primeiroTermo+ " ");
            Console.Write(segundoTermo);

            for (int i=3; i <= num; i++)
            {
                novo = primeiroTermo + segundoTermo;
                Console.Write(" " + novo);
                primeiroTermo = segundoTermo;
                segundoTermo = novo;
            }

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
