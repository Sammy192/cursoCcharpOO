﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menorNumerodetres
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;

            String[] vet = Console.ReadLine().Split(' ');

            x = int.Parse(vet[0]);
            y = int.Parse(vet[1]);
            z = int.Parse(vet[2]);

            if (x < y && x < z)
            {
                Console.WriteLine("MENOR = " + x);
            }
            else if (y < z)
            {
                Console.WriteLine("MENOR = " + y);
            }
            else
            {
                Console.WriteLine("MENOR = " + z);
            }


            Console.ReadLine();


        }
    }
}
