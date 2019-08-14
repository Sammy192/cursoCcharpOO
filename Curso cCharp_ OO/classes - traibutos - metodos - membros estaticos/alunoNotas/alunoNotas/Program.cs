using System;
using System.Globalization;

namespace alunoNotas {
    class Program {
        static void Main(string[] args) {

            Aluno alunoX = new Aluno();


            Console.WriteLine("Digite os dados do Aluno:");
            Console.Write("Nome: ");
            alunoX.Nome = Console.ReadLine();
            Console.WriteLine("Digite as 3 notas do aluno: ");
            alunoX.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            alunoX.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            alunoX.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);



            Console.WriteLine("---------------");
            Console.WriteLine("Dados do aluno: " + alunoX.Nome);
            Console.WriteLine("Notal final: " + alunoX.SomaNotaFinal().ToString("F2", CultureInfo.InvariantCulture));

            if (alunoX.AprovadoOuReprovado()) {
                Console.WriteLine("APROVADO");
            }
            else {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM "
                + alunoX.NotaRestante().ToString("F2", CultureInfo.InvariantCulture)
                + " PONTOS");
            }



        }
    }
}
