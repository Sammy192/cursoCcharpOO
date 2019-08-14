using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace mediaAbPONDERADA
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, MEDIA;
            A = double.Parse(Console.ReadLine());
            B = double.Parse(Console.ReadLine());
            MEDIA = ((A * 3.5 ) + ( B * 7.5 )) / 11;
            Console.WriteLine("MEDIA = " + MEDIA.ToString("F5"));
            Console.ReadLine();
        }
    }
}
