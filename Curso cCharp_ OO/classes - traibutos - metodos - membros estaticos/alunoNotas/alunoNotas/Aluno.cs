using System;
using System.Globalization;

namespace alunoNotas {
    class Aluno {

        public string Nome;
        public double Nota1, Nota2, Nota3;

        public double SomaNotaFinal() {
            return Nota1 + Nota2 + Nota3;
        }
        public bool AprovadoOuReprovado() {
            if (SomaNotaFinal() >= 60.0) {
                return true;
            }
            else {
                return false;
            }
        }

        public double NotaRestante() {
            if (AprovadoOuReprovado()) {
                return 0.0;
            }
            else {
                return 60.0 - SomaNotaFinal();
            }
        }
    }
}
