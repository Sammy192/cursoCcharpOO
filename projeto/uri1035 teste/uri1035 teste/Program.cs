﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri1035_teste
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;

            string[] vet = Console.ReadLine().Split(' ');
            a = int.Parse(vet[0]);
            b = int.Parse(vet[1]);
            c = int.Parse(vet[2]);
            d = int.Parse(vet[3]);

           if(b > c && d > a && (c + d) > (a + b) && c > 0 && d > 0 && (a % 2) == 0)
           
            {
                Console.WriteLine("Valores aceitos");
            }
            else
            {
                Console.WriteLine("Valores nao aceitos");
            }


            Console.ReadLine();
        }
    }
}
