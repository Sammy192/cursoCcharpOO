using System;

namespace firstExercicio_oo
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa a, b;

            a = new Pessoa();
            b = new Pessoa();

            Console.WriteLine("Entre com nome e idade da primeira pessoa: ");
            a.nome = Console.ReadLine();
            a.idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com nome e idade da segunda pessoa: ");
            b.nome = Console.ReadLine();
            b.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("-------------------------");
            Console.WriteLine(a.nome + " - " + a.idade);
            Console.WriteLine(b.nome + " - " + b.idade);

            if (a.idade > b.idade) {
                Console.WriteLine("Pessoa mais velha: "+ a.nome);
            }
            else {
                Console.WriteLine("Pessoa mais velha: "+b.nome);
            }
        }
    }
}
