using System;
using System.Collections.Generic;
using System.Text;

namespace Imposto.Entities {
    class Individual : TaxPayer {
        public double DespesasSaude { get; set; }

        public Individual() {
        }

        public Individual(string name, double anualIncome, double despesasSaude) :base(name,anualIncome) {
            DespesasSaude = despesasSaude;
        }



        public override double Tax() {
            if (AnualIncome < 20000.0) {
                return (AnualIncome * 0.15) - (DespesasSaude * 0.5);
            }
            else {
                return (AnualIncome * 0.25) - (DespesasSaude * 0.5);
            }
        }


    }
}
