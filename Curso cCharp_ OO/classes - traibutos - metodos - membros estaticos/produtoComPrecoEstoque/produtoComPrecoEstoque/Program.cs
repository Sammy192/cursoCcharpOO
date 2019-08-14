using System;
using System.Globalization;

namespace produtoComPrecoEstoque {
    class Program {
        static void Main(string[] args) {

            

            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preco: ");
            double preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Quantidade no estoque: ");
            int QuantidadeProdutoEstoqueAtual = int.Parse(Console.ReadLine());

            Produto p = new Produto(nome,preco,QuantidadeProdutoEstoqueAtual);


            Console.WriteLine();
            Console.WriteLine("Dados do produto: "+ p );
            Console.WriteLine();

            //adicionar quantidade ao estoque
            Console.Write("Digite a quantidade de produtos para ser adicionado ao estoque atual: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados do produto: "+ p);
            Console.WriteLine();

            //remover quantidade do estoque
            Console.Write("Digite a quantidade de produtos para ser REMOVIDO do estoque atual: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados do produto: " + p);
            Console.WriteLine();


        }
    }
}
