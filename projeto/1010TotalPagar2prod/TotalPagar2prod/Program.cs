using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalPagar2prod_vet
{
    class Program
    {
        static void Main(string[] args)
        {
            int codProd1, codProd2, quantProd1, quantProd2;
            double custoUnProd1, custoUnProd2, totalPagar;
            string[] vet;

            vet = Console.ReadLine().Split(' ');
            codProd1 = int.Parse(vet[0]);
            quantProd1 = int.Parse(vet[1]);
            custoUnProd1 = double.Parse(vet[2]);

            vet = Console.ReadLine().Split(' ');
            codProd2 = int.Parse(vet[0]);
            quantProd2 = int.Parse(vet[1]);
            custoUnProd2 = double.Parse(vet[2]);

            totalPagar = (quantProd1 * custoUnProd1) + (quantProd2 * custoUnProd2);
            Console.WriteLine("VALOR A PAGAR: R$ " + totalPagar.ToString("f2"));
            Console.ReadLine();
        }
    }
}
