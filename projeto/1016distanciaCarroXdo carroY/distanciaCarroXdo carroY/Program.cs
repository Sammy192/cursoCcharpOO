using System;
namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int distancia, tempo;
            distancia = int.Parse(Console.ReadLine());
            // Raciocinio: se o carro Y consegue se afastar 1 km a cada 2 minutos,
            // para descobrir o tempo basta multiplicar a distancia por 2
            tempo = distancia * 2;
            Console.WriteLine(tempo + " minutos");
            Console.ReadLine();
        }
    }
}