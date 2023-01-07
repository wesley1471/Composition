using System;
using System.Globalization;
using Exercicio.Entities;
using Exercicio.Entities.Enums;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            

            Client client = new Client(name, email, birthDate);
            Order order = new Order(status, client, DateTime.Now);

            Console.Write("How many items to this order? ");
            int qnt = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qnt; i++)
            {
                Console.WriteLine($"Enter {i} item data:");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Product product = new Product(productName, price);
                Console.Write("Quantity: ");
                int qtd = int.Parse(Console.ReadLine());
                OrderItem orderItem = new OrderItem(qnt,product,price);

                order.AddItem(orderItem);
            }
            
            Console.WriteLine();
            Console.WriteLine(order);
        }
    }
}