using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace uri1048
{
    class Program
    {
        static void Main(string[] args)
        {
            double salarioAtual, novoSalario,perc;

            salarioAtual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            novoSalario = 0;
            perc = 0;

            if (salarioAtual > 0 && salarioAtual <= 400.00)
            {
                novoSalario = (salarioAtual * 0.15 ) + salarioAtual;
                perc = 15;
            }else if (salarioAtual >= 400.01 && salarioAtual <= 800.00)
            {
                novoSalario = (salarioAtual * 0.12) + salarioAtual;
                perc = 12;
            }else if (salarioAtual >= 800.01 && salarioAtual <= 1200.00)
            {
                novoSalario = (salarioAtual * 0.10) + salarioAtual;
                perc = 10;
            }else if (salarioAtual >= 1200.01 && salarioAtual <= 2000.00)
            {
                novoSalario = (salarioAtual * 0.07) + salarioAtual;
                perc = 7;
            }else if (salarioAtual > 2000.00)
            {
                novoSalario = (salarioAtual * 0.04) + salarioAtual;
                perc = 4;
            }

            Console.WriteLine("Novo salario: "+ novoSalario.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Reajuste ganho: " + (novoSalario - salarioAtual).ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Em percentual: " + perc + " %");

            Console.ReadLine();

        }
    }
}
