using System;
using System.Globalization;

namespace segundoExerc_oo
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1, f2;

            f1 = new Funcionario();
            f2 = new Funcionario();

            Console.WriteLine("Entre com nome e salario do primeiro funcionário: ");
            f1.nome = Console.ReadLine();
            f1.salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com nome e salario do segundo funcionário: ");
            f2.nome = Console.ReadLine();
            f2.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salarioMedio = 0.0;

            salarioMedio = (f1.salario + f2.salario) / 2.0;

            Console.WriteLine("Salario medio: "+ salarioMedio.ToString("F2",CultureInfo.InvariantCulture));

        }
    }
}
