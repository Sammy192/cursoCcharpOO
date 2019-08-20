using System;
using System.Collections.Generic;
using FuncionariosTerceirizados.Entities;
using System.Globalization;

namespace FuncionariosTerceirizados {
    class Program {
        static void Main(string[] args) {
            Console.Write("Entre com o numero de funcionarios: ");
            int n = int.Parse(Console.ReadLine());

            List<Employee> ListaEmpregado = new List<Employee>();


            for (int i=1;i<=n;i++) {
                Console.WriteLine($"Digite os dados do trabalhador numero {i} : ");
                Console.Write("Terceirizado y/n: ");
                char ch = char.Parse(Console.ReadLine());
                Console.WriteLine("Nome do trabalhador: ");
                string name = Console.ReadLine();
                Console.WriteLine("Quantidade de horas: ");
                int hours = int.Parse(Console.ReadLine());
                Console.WriteLine("Valor por hora: ");
                double valuePerHour = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                if (ch == 'y') {
                    Console.WriteLine("Digite a despesa adicional: ");
                    double additionalCharge = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    ListaEmpregado.Add(new OutSourcedEmployee(name, hours, valuePerHour, additionalCharge));
                }
                else {
                    ListaEmpregado.Add(new Employee(name, hours, valuePerHour));
                }
            }

            Console.WriteLine();
            Console.WriteLine("Pagamentos realizados: ");

            foreach (Employee emp in ListaEmpregado) {
                Console.WriteLine(emp.Name + " - $ " + emp.Payment().ToString("F2",CultureInfo.InvariantCulture));
            }


        }
    }
}
