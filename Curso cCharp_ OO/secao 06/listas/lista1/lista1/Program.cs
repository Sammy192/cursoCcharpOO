using System;
using System.Collections.Generic;
using System.Globalization;

namespace lista1 {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Digita um numero: ");
            int n = int.Parse(Console.ReadLine());

            List<Funcionario> List = new List<Funcionario>();

            for (int i=1; i<= n;i++) {
                Console.WriteLine("Funcionario: # "+i);
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salario: ");
                double salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                List.Add(new Funcionario(id, nome, salario));
                Console.WriteLine();
            }

            Console.WriteLine("Entre com o ID do funcionario que deseja aumentar o salario: ");
            int idProcurar = int.Parse(Console.ReadLine());

            Funcionario emp = List.Find(x => x.Id == idProcurar);
            if (emp != null) {
                Console.Write("Entre com o percentual de aumento: ");
                double percentual = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                emp.AumentaSalario(percentual);
            }
            else {
                Console.WriteLine("Este ID no existssss");
            }

            Console.WriteLine();

            Console.WriteLine("Lista atualizada: ");
            foreach (Funcionario obj in List) {
                Console.WriteLine(obj);
            }


        }
    }
}
