using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exer6
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            string[] nomes = new string[num];
            int[] idades = new int[num];

            for (int i=0; i<num; i++)
            {
                string[] entradaDados = Console.ReadLine().Split(' ');
                nomes[i] = entradaDados[0];
                idades[i] = int.Parse(entradaDados[1]);
            }

            int maior = 0;
            int posicaoMaior = 0 ;
            for (int i =0;i <num;i++)
            {
                if (idades[i] > maior)
                {
                    maior = idades[i];
                    posicaoMaior = i;
                }
            }


            //Console.WriteLine("Pessoa mais velha: " + maior + " " + nomes[posicaoMaior] );
            Console.WriteLine("Pessoa mais velha: " + nomes[posicaoMaior] );

            /*
            //soh mostrar na tela os dois vetores

            for (int i=0; i<num;i++)
            {
                Console.WriteLine(nomes[i] + " " +idades[i] );
            }*/

            Console.ReadLine();


        }
    }
}
