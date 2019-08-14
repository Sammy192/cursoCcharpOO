using System;

namespace exer1_vetor_oo {
    class Program {
        static void Main(string[] args) {
            int tamanhoVetor = 10;


            Console.WriteLine("Quantos quartos serão alugados: ");
            int n = int.Parse(Console.ReadLine());
            

            Reserva[] vetReserva = new Reserva[tamanhoVetor];

            for (int i=1; i <=n;i++) {
                

                Console.WriteLine($"Reserva numero: #{i} ");
                Console.Write("Nome: ");
                string nomeTemp = Console.ReadLine();
                Console.Write("Email: ");
                string emailTemp = Console.ReadLine();
                Console.Write("Numero do quarto: ");
                int numQuartoTemp = int.Parse(Console.ReadLine());

                Console.WriteLine();
                vetReserva[numQuartoTemp] = new Reserva(nomeTemp,emailTemp);
            }


            Console.WriteLine("Quartos ocupados: ");
            for (int i=0; i< tamanhoVetor; i++) {
                if (vetReserva[i] != null) {
                    Console.WriteLine($"Numero quarto: {i}  - {vetReserva[i] } ");
                }
            }


        }
    }
}
