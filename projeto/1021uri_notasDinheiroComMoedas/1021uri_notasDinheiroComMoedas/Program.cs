using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1021uri_notasDinheiroComMoedas
{
    class Program
    {
        static void Main(string[] args)
        {

            double N, parteDecimal;
            double resto, notas100, notas50, notas20, notas10, notas5, notas2, moeda1, moeda050, moeda025, moeda010, moeda005, moeda001;
            N = double.Parse(Console.ReadLine());
            notas100 = (int)N / 100;
            resto = (double)N % 100.00;

            notas50 = (int)resto / 50;
            resto = (double)resto % 50.00;

            notas20 = (int)resto / 20;
            resto = (double)resto % 20.00;

            notas10 = (int)resto / 10;
            resto = (double)resto % 10.00;

            notas5 = (int)resto / 5;
            resto = (double)resto % 5.0;

            notas2 = (int)resto / 2;
            resto = (double)resto % 2.00;


            moeda1 = (int)resto / 1;
            resto = (double)resto % 1;



            moeda050 = (int)resto / 0.5;
            resto = (double)resto % 0.50;

            moeda025 = (int)resto / 0.25;
            resto = (double) moeda025 % 0.25;
            moeda010 = (int)resto / 0.10;
            resto = (double)moeda010 % 0.10;
            moeda005 = (int)resto / 0.05;
            resto = (double)moeda005 % 0.05;
            moeda001 = (int)resto / 1;

            Console.WriteLine(notas100 + " nota(s) de 100,00 ");
            Console.WriteLine(notas50 + " nota(s) de 50,00 ");
            Console.WriteLine(notas20 + " nota(s) de 20,00 ");
            Console.WriteLine(notas10 + " nota(s) de 10,00 ");
            Console.WriteLine(notas5 + " nota(s) de 5,00 ");
            Console.WriteLine(notas2 + " nota(s) de 2,00 ");
            Console.WriteLine(moeda1 + " moeda(s) de 1,00 ");
            Console.WriteLine(moeda050 + " moeda(s) de 0,50 ");
            Console.WriteLine(moeda025 + " moeda(s) de 0,25 ");
            Console.WriteLine(moeda010 + " moeda(s) de 0,10 ");
            Console.WriteLine(moeda005 + " moeda(s) de 0,05 ");
            Console.WriteLine(moeda001 + " moeda(s) de 0,01 ");

            Console.ReadLine();
        }

    }

}