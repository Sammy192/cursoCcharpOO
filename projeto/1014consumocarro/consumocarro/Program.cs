using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consumocarro
{
    class Program
    {
        static void Main(string[] args)
        {
            int quilometragem;
            double litrosGastos,consumoMedio;

            quilometragem = int.Parse(Console.ReadLine());
            litrosGastos = double.Parse(Console.ReadLine());
            consumoMedio = quilometragem / litrosGastos;
            Console.WriteLine(consumoMedio.ToString("f3") + " km/l");
            Console.ReadLine();
            
        }
    }
}
