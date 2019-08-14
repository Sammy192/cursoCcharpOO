using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri1072
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, dentroInvervalo, foraintervalo,repeticao;


            repeticao = int.Parse(Console.ReadLine());
            dentroInvervalo = 0;
            foraintervalo = 0;


            for (int i= 0; i < repeticao ; i++ )
            {
                num = int.Parse(Console.ReadLine());
                if ( num >=10 && num <=20)
                {
                    dentroInvervalo = dentroInvervalo + 1;
                }
                else
                {
                    foraintervalo = foraintervalo + 1;
                }             

            }
            Console.WriteLine(dentroInvervalo + " in");
            Console.WriteLine(foraintervalo + " out");

            Console.ReadLine();
        }
    }
}
