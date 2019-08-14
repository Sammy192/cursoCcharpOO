using System;
using System.Collections.Generic;
using System.Text;

namespace areaPerimetroDiagonal_retang {
    class Retangulo {

        public double Largura;
        public double Altura;

        public double Area() {
            return Largura * Altura;
        }

        public double Perimetro() {
            return 2 * (Altura + Largura);
        }

        public double Diagonal() {
            //diag2= b2+h2 ou d=√b2+h2
            return Math.Sqrt(Largura * Largura + Altura * Altura);
        }

    }
}
