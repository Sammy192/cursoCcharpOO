using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace exemplo3
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] a;
            int num = int.Parse(Console.ReadLine());
            double soma = 0.0;
            a = new double[num];
            string[] s = Console.ReadLine().Split(' ');



            for (int i=0; i<num;i++)
            {
                a[i] = double.Parse(s[i],CultureInfo.InvariantCulture);
            }

            for (int i =0; i <num;i++)
            {
                Console.Write(a[i].ToString("F1",CultureInfo.InvariantCulture) + " ");
                soma = soma + a[i];
            }
            Console.WriteLine();
            double media = soma / num;

            Console.WriteLine(soma.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine(media.ToString("F2",CultureInfo.InvariantCulture));
            Console.ReadLine();

        }
    }
}
