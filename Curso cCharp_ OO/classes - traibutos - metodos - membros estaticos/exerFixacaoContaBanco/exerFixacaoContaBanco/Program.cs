using System;
using System.Globalization;

namespace exerFixacaoContaBanco {
    class Program {
        static void Main(string[] args) {

            Conta contaX;

            double valorQualquer = 0.0;

            Console.Write("Entre o número da conta: ");
            int contaNumero = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta:");
            string nomeTitular = Console.ReadLine();
            Console.Write("Haverá deposito inicial: (s/n)- ");
            char op = char.Parse(Console.ReadLine());

            
            if (op == 'S' || op == 's') {
                Console.Write("Entre o valor de depósito inicial: ");
                valorQualquer = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                contaX = new Conta(contaNumero, nomeTitular, valorQualquer);
            }
            else { 
                contaX = new Conta(contaNumero, nomeTitular);                
            }


            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(contaX);

            Console.Write("Entre com um valor para depósito: ");
            valorQualquer = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            contaX.DepositarValor(valorQualquer);

            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(contaX);

            Console.Write("Entre com um valor para saque: ");
            valorQualquer = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            contaX.RetirarValor(valorQualquer);

            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(contaX);


        }
    }
}
