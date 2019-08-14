using System;
using System.Globalization;
namespace teste
{
    class Program
    {
        static void Main(string[] args)
        {

            int idade = 32;
            double saldo = 10.35784;
            String nome = "Maria";
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2} reais", nome, idade, saldo.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo.ToString("F3",CultureInfo.InvariantCulture)} reais");
           // Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a "+ saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais");


        }
    }
}
