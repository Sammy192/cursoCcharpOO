using System;
using System.Globalization;

namespace cotacaoDolar {
    class Program {
        static void Main(string[] args) {




            Console.WriteLine("Qual é a cotação do dolar atual: ");
            double dolarAt = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Quantos dólares você vai comprar? ");
            double qtdDolarComprar= double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double valorAPagarSemIOF = Conversao.CalcularEmReais(dolarAt, qtdDolarComprar);
            double valorAPagarComIOF = Conversao.CalcularTotalPagarMaisIof();

            Console.WriteLine("Valor a ser pago em reais sem IOF = " + valorAPagarSemIOF.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor a ser pago em reais com IOF = "+ valorAPagarComIOF.ToString("F2",CultureInfo.InvariantCulture));

        }
    }
}
