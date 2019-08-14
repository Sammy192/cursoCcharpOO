using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salario
{
    class Program
    {
        static void Main(string[] args)
        {
            int matricula;
            double horasTrabalhadas, valorHora, salario;
            matricula = int.Parse(Console.ReadLine());
            horasTrabalhadas = double.Parse(Console.ReadLine());
            valorHora = double.Parse(Console.ReadLine());
            salario = (horasTrabalhadas * valorHora);
            Console.WriteLine("NUMBER = " + matricula);
            Console.WriteLine("SALARY = U$ " + salario.ToString("F2"));
            Console.ReadLine();
        }
    }
}
