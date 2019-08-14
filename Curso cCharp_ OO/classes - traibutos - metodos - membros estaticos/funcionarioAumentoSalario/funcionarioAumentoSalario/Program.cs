using System;
using System.Globalization;


namespace funcionarioAumentoSalario {
    class Program {
        static void Main(string[] args) {

            Funcionario funcionarioX = new Funcionario();
            Console.WriteLine("Entre com os dados do funcionário: ");
            Console.Write("Nome: ");
            funcionarioX.Nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            funcionarioX.SalarioBruto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            funcionarioX.Imposto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("----------------");
            Console.WriteLine("Dados do funcionário: ");
            Console.WriteLine(funcionarioX);

            Console.Write("Digite o percentual de aumento no salario: ");
            double percentualAumento = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            //chamando funcao para aumento de salario
            funcionarioX.AumentarSalario(percentualAumento);

            Console.Write("Dados atualizados: " + funcionarioX);


            Console.WriteLine();
        }
    }
}
