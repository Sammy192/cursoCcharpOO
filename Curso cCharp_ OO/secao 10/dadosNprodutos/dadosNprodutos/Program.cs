using System;
using System.Globalization;
using dadosNprodutos.Entities;
using System.Collections.Generic;

namespace dadosNprodutos {
    class Program {
        static void Main(string[] args) {

            List<Product> List = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i=1; i <= n; i++) {
                Console.WriteLine($"Enter with date of product: {i}");
                Console.Write("Common, used or imported (c/u/i)? ");
                char op = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string nameX = Console.ReadLine();
                Console.Write("Price: ");
                double priceX = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                if (op == 'i') {
                    Console.Write("Customs fee: ");
                    double customFeex = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    List.Add(new ImportedProduct(nameX,priceX,customFeex));
                }
                else if (op == 'c') {
                    List.Add(new Product(nameX, priceX));
                }
                else {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime dateX = DateTime.Parse(Console.ReadLine());
                    List.Add(new UsedProduct(nameX,priceX,dateX));
                }
                Console.WriteLine("--------------------------------------------------------");
            }

            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Details of price tags: ");
            foreach (Product pro in List) {
                Console.WriteLine("--------------------------------------------------------");
                Console.WriteLine(pro.PriceTag());
            }
            Console.WriteLine();


        }
    }
}
