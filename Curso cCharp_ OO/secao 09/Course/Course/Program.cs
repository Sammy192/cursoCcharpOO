using Course.Entities;
using Course.Entities.Enums;
using System;

namespace Course {
    class Program {
        static void Main(string[] args) {

            Order order = new Order {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            //de enum para string
            string txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(txt);
            // de string para enum

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(os);



        }
    }
}
