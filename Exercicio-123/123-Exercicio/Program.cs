using System;
using System.Collections.Generic;
using System.Globalization;
using _123_Exercicio.Entities;
using _123_Exercicio.Entities.Enums;

namespace _123_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string clientName = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth Date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client = new Client(clientName, email, birthDate);
            //Cria ordem linkando o objeto Client
            Order order = new Order(DateTime.Now, status, client);

            Console.Write("How many items for this order? ");
            int items = int.Parse(Console.ReadLine());


            for (int i = 1; i <= items; i++)
            {
                Console.WriteLine($"Enter #{i} item data: ");

                Console.Write("Product name: ");
                string productName = Console.ReadLine();

                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine());

                Product p = new Product(productName, productPrice);

                Console.Write("Quantity: ");
                int productQuantity = int.Parse(Console.ReadLine());

                OrderItem o = new OrderItem(productQuantity, productPrice, p);
                order.AddItem(o);
            }

            Console.WriteLine(order.ToString());

            
        }
    }
}
