using System;
using System.Globalization;

namespace areaPerimetroDiagonal_retang {
    class Program {
        static void Main(string[] args) {

            Retangulo medidasRetangulo = new Retangulo();

            Console.WriteLine("Digite a largura do retangulo: ");
            medidasRetangulo.Largura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Digite a altura do retangulo: ");
            medidasRetangulo.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            
            Console.WriteLine("AREA = " + medidasRetangulo.Area().ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("PERÍMETRO: " + medidasRetangulo.Perimetro().ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL: "+medidasRetangulo.Diagonal().ToString("F2",CultureInfo.InvariantCulture));


        }
    }
}
