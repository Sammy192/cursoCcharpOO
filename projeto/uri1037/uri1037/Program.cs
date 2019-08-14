using System;
using System.Globalization;

namespace uri1037
{
    class Program
    {
        static void Main(string[] args){

            double x;
            string intervalo;
            x = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            if (x >= 0.0 && x <= 25.00)
            {
                intervalo = "Intervalo [0,25]";
            }
            else if (x >= 25.00 && x <= 50.00)
            {
                intervalo = "Intervalo (25,50]";
            }
            else if (x >= 50.00 && x <= 75.00)
            {
                intervalo = "Intervalo (50,75]";
            }
            else if (x >= 75.00 && x <= 100.00)
            {
                intervalo = "Intervalo (75,100]";
            }
            else
                intervalo = "Fora de intervalo";

            Console.WriteLine(intervalo);

            Console.ReadLine();

        }
    }
}
