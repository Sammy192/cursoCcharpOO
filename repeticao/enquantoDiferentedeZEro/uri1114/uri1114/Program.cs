using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri1114
{
    class Program
    {
        static void Main(string[] args)
        {
            int senha,senhaDefinida;

            senha = int.Parse(Console.ReadLine());

            senhaDefinida = 2002;
            while ( senha != senhaDefinida)
            {
                Console.WriteLine("Senha Invalida");
                senha = int.Parse(Console.ReadLine());
            }            
            Console.WriteLine("Acesso Permitido");
            Console.ReadLine();
        }
    }
}
