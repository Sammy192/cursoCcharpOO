using System;
using System.Globalization;
namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int tempo, velocidade, distancia;
            double litros;
            tempo = int.Parse(Console.ReadLine());
            velocidade = int.Parse(Console.ReadLine());
            // Para encontrar a distancia total, basta multiplicar o tempo pela velocidade
            distancia = tempo * velocidade;
            // Se o automovel consome 1 litro a cada 12 quilometros, para encontrar a
            // quantidade de litros basta dividir a distancia total por 12
            litros = (double)distancia / 12.0;
            Console.WriteLine(litros.ToString("F3", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}