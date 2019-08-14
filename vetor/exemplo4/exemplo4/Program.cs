using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace exemplo4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            string[] nomes = new string[num];
            int[] idades = new int[num];
            double[] alturas = new double[num];


            //leitura dos dados
            for (int i=0; i < num;i++)
            {
                string[] aux = Console.ReadLine().Split(' ');
                nomes[i] = aux[0];
                idades[i] = int.Parse(aux[1]);
                alturas[i] = double.Parse(aux[2],CultureInfo.InvariantCulture);
            }

            //calculo da altura media das pessoas
            double soma = 0.0;
            for (int i =0; i <num;i++)
            {
                soma = soma + alturas[i];
            }

            double media = soma / num;
            Console.WriteLine("Altura media: "+media.ToString("F2",CultureInfo.InvariantCulture));

            //PORCENTAGEM DE PESSOAS ABAIXO DE 16 ANOS

            int cont = 0;
            for (int i=0; i <num; i++)
            {
                if (idades[i] < 16)
                {
                    cont++;
                }
            }
            double porcentagel = (double) cont / num * 100.00;
            Console.WriteLine("Pessoas com menos de 16 anos: " + porcentagel.ToString("F1",CultureInfo.InvariantCulture) + "%");

            Console.ReadLine();
        }
    }
}
