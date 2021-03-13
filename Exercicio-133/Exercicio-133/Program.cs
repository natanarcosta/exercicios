using System;
using System.Globalization;
using Exercicio_133.Entities;
using System.Collections.Generic;

namespace Exercicio_133
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());
            List<Product> product = new List<Product>();
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string productName = Console.ReadLine();
                Console.Write("Price: $");
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (ch == 'c')
                {
                    product.Add(new Product(productName, productPrice));
                } else if (ch == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    product.Add(new UsedProduct(productName, productPrice, manufactureDate));
                } else if (ch == 'i')
                {
                    Console.Write("Customs fee: $");
                    double fee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    product.Add(new ImportedProduct(productName, productPrice, fee));
                }

            }
            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");
            foreach(Product prod in product)
            {
                Console.WriteLine(prod.PriceTag()); 
            }
        }
    }
}
