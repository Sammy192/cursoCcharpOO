using System;
using Figura.Entities.Enums;
using Figura.Entities;
using System.Collections.Generic;
using System.Globalization;

namespace Figura {
    class Program {
        static void Main(string[] args) {

            List<ShapeFigura> list = new List<ShapeFigura>(); 

            Console.Write("Entre com a qtd de fig: ");
            int n = int.Parse(Console.ReadLine());

            for ( int i=1;i <= n;i++) {
                Console.WriteLine($"Figura num {i}");
                Console.Write("Retangulo ou circulo (r/c): ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());
                if (ch == 'r') {
                    Console.Write("Largura: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Altura: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Rectangle(width, height, color));
                }
                else {
                    Console.Write("Raio: ");
                    double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Circle(raio,color));
                }

            }
            Console.WriteLine();
            Console.WriteLine("Areas: ");
            foreach (ShapeFigura fig in list) {
                Console.WriteLine(fig.Area().ToString("F2",CultureInfo.InvariantCulture));
            }

        }
    }
}
