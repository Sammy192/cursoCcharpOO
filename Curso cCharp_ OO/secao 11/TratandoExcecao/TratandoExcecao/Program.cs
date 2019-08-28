using System;
using System.Globalization;
using TratandoExcecao.Exception;
using TratandoExcecao.Entities;


namespace TratandoExcecao {
    class Program {
        static void Main(string[] args) {


            
                double valorQualquer = 0.0;

                Console.Write("Entre o número da conta: ");
                int contaNumero = int.Parse(Console.ReadLine());
                Console.Write("Entre o titular da conta:");
                string nomeTitular = Console.ReadLine();
                Console.Write("Valor inicial: ");
                valorQualquer = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Valor limite de saque: ");
                double valorLimiteSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account contaX = new Account(contaNumero, nomeTitular, valorQualquer, valorLimiteSaque);

                Console.WriteLine();
                Console.WriteLine("Dados da conta:");
                Console.WriteLine(contaX);

                //Console.Write("Entre com um valor para depósito: ");
                //valorQualquer = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                //contaX.Deposit(valorQualquer);

                //Console.WriteLine("Dados da conta atualizados:");
                //Console.WriteLine(contaX);

                Console.Write("Entre com um valor para saque: ");
                valorQualquer = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
            try {
                contaX.Withdraw(valorQualquer);
                Console.WriteLine("Dados da conta atualizados:");
                Console.WriteLine(contaX);
            }
            catch ( DomainException e) {
                Console.WriteLine("Error: " + e.Message);
            }

        }
    }
}
