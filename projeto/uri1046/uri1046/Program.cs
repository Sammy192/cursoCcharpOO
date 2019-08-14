using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri1046
{
    class Program
    {
        static void Main(string[] args)
        {
            int hInicio, hFinal, tempo;
            string[] vet = Console.ReadLine().Split(' ');

            hInicio = int.Parse(vet[0]);
            hFinal = int.Parse(vet[1]);


            if (hInicio < hFinal)
            {
                tempo = hFinal - hInicio;

            }
            else
            {
                tempo = (24 - hInicio) + hFinal;

            }

            Console.WriteLine("O JOGO DUROU " + tempo + " HORA(S)");

            Console.ReadLine();

        }
    }
}
