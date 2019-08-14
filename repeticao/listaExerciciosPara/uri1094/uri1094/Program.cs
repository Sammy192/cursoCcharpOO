using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace uri1094
{
    class Program
    {
        static void Main(string[] args)
        {
            int repeticao,qtdDigitada,qtdRato,qtdSapo,qtdCoelho,qntdTotalCobaias;
            char tipoCobaia;
            repeticao = int.Parse(Console.ReadLine());

            qtdRato = 0;
            qtdSapo = 0;
            qtdCoelho = 0;
            qntdTotalCobaias = 0;
            for (int i=0; i < repeticao; i++)
            { 
                string[] vet = Console.ReadLine().Split(' ');
                qtdDigitada = int.Parse(vet[0]);
                tipoCobaia = char.Parse(vet[1]);               
                
                    if (tipoCobaia == 'C')
                        qtdCoelho = qtdCoelho + qtdDigitada;
                    else if (tipoCobaia == 'R')
                        qtdRato = qtdRato + qtdDigitada;
                    else
                        qtdSapo = qtdSapo + qtdDigitada;                
            }

            qntdTotalCobaias = qtdCoelho + qtdRato + qtdSapo;
            double porcentagemCoelhos = (double)qtdCoelho / qntdTotalCobaias * 100.0;
            double porcentagemRatos = (double)qtdRato / qntdTotalCobaias * 100.0;
            double porcentagemSapos = (double)qtdSapo / qntdTotalCobaias * 100.0;

            Console.WriteLine("Total: " + qntdTotalCobaias  + " cobaias");
            Console.WriteLine("Total de coelhos: "+qtdCoelho);
            Console.WriteLine("Total de ratos: "+ qtdRato);
            Console.WriteLine("Total de sapos: "+ qtdSapo);
            Console.WriteLine("Percentual de coelhos: " + porcentagemCoelhos.ToString("F2",CultureInfo.InvariantCulture) + " %");
            Console.WriteLine("Percentual de ratos: " + porcentagemRatos.ToString("F2", CultureInfo.InvariantCulture) + " %");
            Console.WriteLine("Percentual de sapos: " + porcentagemSapos.ToString("F2", CultureInfo.InvariantCulture) + " %");

            Console.ReadLine();
        }
    }
}
