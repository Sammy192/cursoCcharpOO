using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace uri1038
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo;
            double quant,total;

            string[] vet = Console.ReadLine().Split(' ');
            codigo = int.Parse(vet[0]);
            quant = int.Parse(vet[1]);

            switch (codigo) {
                case 1:
                    total = quant * 4.00;
                    break;
                case 2:
                    total = quant * 4.50;
                    break;
                case 3:
                    total = quant * 5.00;
                    break;
                case 4:
                    total = quant * 2.00;
                    break;
                case 5:
                    total = quant * 1.50;
                    break;
                default:
                    total = 0;
                    break;
            }

            Console.WriteLine("Total: R$ " + total.ToString("F2",CultureInfo.InvariantCulture));
            Console.ReadLine();




        }
    }
}
