using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri1134
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao,alcool,gasolina, diesel;

            // 1.Álcool 2.Gasolina 3.Diesel 4.Fim
            opcao = int.Parse(Console.ReadLine());

            alcool = 0;
            gasolina = 0;
            diesel = 0;
           
            while (opcao != 4 )
            {
                if (opcao >=1 && opcao < 4)
                {
                    if (opcao == 1)
                    {
                        alcool = alcool + 1;
                    }
                    if (opcao == 2)
                    {
                        gasolina = gasolina + 1;
                    }
                    if (opcao == 3)
                    {
                        diesel = diesel + 1;
                    }
                }
                /*else
                {
                    Console.WriteLine("valor invalido, digite novamente");
                }*/
                opcao = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: "+ alcool);
            Console.WriteLine("Gasolina: "+gasolina);
            Console.WriteLine("Diesel: "+diesel);
            Console.ReadLine();


        }
    }
}
