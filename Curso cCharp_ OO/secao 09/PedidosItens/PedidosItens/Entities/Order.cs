using System;
using System.Collections.Generic;
using System.Text;
using PedidosItens.Entities.Enums;
using PedidosItens.Entities;
using System.Globalization;

namespace PedidosItens.Entities {
    class Order {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Cliente { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        

        public Order() {
        }

        public Order(DateTime moment, OrderStatus status, Client cliente) {
            Moment = moment;
            Status = status;
            Cliente = cliente;
        }

        public void AdicionarItem(OrderItem item) {
            Items.Add(item);
        }

        public void RemoverItem(OrderItem item) {
            Items.Remove(item);
        }

        public double Total() {
            double sum = 0.0;
            foreach (OrderItem item in Items) {
                sum += item.SubTotal();
            }
            return sum;
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("---------- RESUMO DO PEDIDO -----------");
            sb.AppendLine("Data pedido: "+ Moment.ToString("dd/mm/yyyy HH:mm:ss"));
            sb.AppendLine("Status do Pedido: " + Status);
            sb.AppendLine("Cliente: " + Cliente);
            sb.AppendLine("Itens do pedido: ");

            foreach (OrderItem itensPed in Items) {
                sb.AppendLine(itensPed.ToString());
            }
            sb.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }


    }
}
