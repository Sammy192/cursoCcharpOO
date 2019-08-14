using System;
using System.Collections.Generic;
using System.Text;

namespace exer1_vetor_oo {
    class Reserva {

        public string Nome { get; set; }
        public string Email { get; set; }
       
        public Reserva(string nome, string email) {
            Nome = nome;
            Email = email;
        }

        public override string ToString() {
            return $"{Nome} - {Email}";
        }


    }
}
