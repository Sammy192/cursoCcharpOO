using System;
using PedidosItens.Entities.Enums;
using PedidosItens.Entities;
using System.Globalization;

namespace PedidosItens {
    class Program {
        static void Main(string[] args) {

            //dados cliente
            Console.WriteLine("Entre com os dados do cliente: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Data nascimento (DD/MM/YYYY):");
            DateTime dataNascimento = DateTime.Parse(Console.ReadLine());
            //fim dados cliente

            //informar o status do pedido
            Console.WriteLine("Entre com o status do pedido:  PendingPayment/Processing/Shipped/Delivered");
            OrderStatus statusPedido = Enum.Parse<OrderStatus>(Console.ReadLine());

            //instanciar o cliente e order
            Client clienteX = new Client(nome, email, dataNascimento);
            Order orderX = new Order(DateTime.Now, statusPedido, clienteX);


            Console.Write("Quanto itens para este pedido: ");
            int repetir = int.Parse(Console.ReadLine());

            for (int i=1; i<=repetir; i++) {
                Console.WriteLine($"Digite os dados do # {i} produto: ");
                Console.Write("Nome do produto: ");
                string nomeProduto = Console.ReadLine();

                Console.Write("Preco do produto: ");
                double precoProduto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                Console.WriteLine("Quantidade: ");
                int qtdProduto = int.Parse(Console.ReadLine());


                Product produtoX = new Product(nomeProduto, precoProduto);
                OrderItem itemX = new OrderItem(qtdProduto, precoProduto, produtoX);
                orderX.AdicionarItem(itemX);
            }

            Console.WriteLine();
            Console.WriteLine(orderX);


        }
    }
}
