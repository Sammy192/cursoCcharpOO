using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conversaoSegundos_hhMMss
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,horas, resto,minutos, segundos;

            n = int.Parse(Console.ReadLine());
            //3600seg
            //1min tem 60s e 1h tem 60min e 1h tem 3600seg
        
            horas = n / 3600; // quantas horas tenho em "n" segundos
            resto = n % 3600;
            minutos = resto / 60; // quantas minutos tenho em "n" segundos
            segundos = resto % 60;

            Console.WriteLine(horas + ":" + minutos + ":" + segundos);
            Console.ReadLine();

        }
    }
}
