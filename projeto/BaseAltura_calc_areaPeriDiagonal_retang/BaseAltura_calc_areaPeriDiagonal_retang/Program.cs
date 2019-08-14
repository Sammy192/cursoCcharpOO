using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace BaseAltura_calc_areaPeriDiagonal_retang
{
    class Program
    {
        static void Main(string[] args){

            Double ba, altura, area, perimetro, diagonal;
            //entrada 5,0 e 4,0 certo esta com ponto

            ba = Double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            altura = Double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            
            area = ba * altura;
            perimetro = ba * 2 + altura * 2;
            diagonal = Math.Sqrt(Math.Pow(ba, 2.0) + Math.Pow(altura, 2.0));

            Console.WriteLine("AREA = " + area.ToString("F4",CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO = " + perimetro.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + diagonal.ToString("F4", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
