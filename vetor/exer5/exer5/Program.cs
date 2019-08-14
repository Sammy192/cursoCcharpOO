using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace exer5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int[] valores = new int[num];

            string[] entradaDados = Console.ReadLine().Split(' ');
            for (int i=0; i <num;i++)
            {
                valores[i] = int.Parse(entradaDados[i]);
            }

            int contaPar = 0;
            int soma = 0;
            for (int i=0; i<num; i++)
            {
                if (valores[i] % 2 == 0)
                {
                    soma = soma + valores[i];
                    contaPar++;
                }
            }

            if (contaPar == 0)
            {
                Console.WriteLine("Não foi digitado nenhum numero par");
            }
            else
            {
                double media = (double)soma / contaPar;
                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }

            

            Console.ReadLine();
        }
    }
}
