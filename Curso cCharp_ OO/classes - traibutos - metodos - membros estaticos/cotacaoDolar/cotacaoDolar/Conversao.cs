using System;
using System.Collections.Generic;
using System.Text;



namespace cotacaoDolar {
    class Conversao {
        public static double Iof = 6.0;

        public static double totalEmReaiSemIof;

        public static double CalcularEmReais(double valorDolar, double QuantidadeDolarComprar) {
            totalEmReaiSemIof = QuantidadeDolarComprar * valorDolar;
            return totalEmReaiSemIof;
        }
        
        public static double CalcularTotalPagarMaisIof() {
            return totalEmReaiSemIof + totalEmReaiSemIof * Iof / 100.0;
        }

    }
}
