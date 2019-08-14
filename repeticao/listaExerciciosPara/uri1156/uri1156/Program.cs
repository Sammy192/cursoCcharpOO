using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace uri1156
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            double den = 1.0, s = 0.0;
            for (num = 1; num <= 39; num += 2)
            {
                s += num / den;
                den *= 2.0;
            }
            Console.WriteLine(s.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();

        }
    }
}
