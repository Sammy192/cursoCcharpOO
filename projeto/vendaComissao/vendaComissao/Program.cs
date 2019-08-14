using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace vendaComissao
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorVendas, salarioBase, salarioFinal, valorComissao, percComissao;
            string nome;
            
            nome = Console.ReadLine();
            salarioBase = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            valorVendas = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            percComissao = 15;
            valorComissao = (valorVendas * percComissao) / 100;
            salarioFinal = salarioBase + valorComissao;

            Console.WriteLine("TOTAL = R$ " + salarioFinal.ToString("F2",CultureInfo.InvariantCulture));
            //Console.WriteLine("TOTAL = R$ " + Math.Round(salarioFinal, 2), CultureInfo.InvariantCulture);
            Console.ReadLine();
        }
    }
}
