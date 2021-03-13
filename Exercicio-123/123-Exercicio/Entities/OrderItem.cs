using System;
using System.Collections.Generic;
using System.Text;
using _123_Exercicio.Entities.Enums;
using System.Globalization;

namespace _123_Exercicio.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product;


        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public double SubTotal()
        {
            return Quantity * Price;
        }
        public override string ToString()
        {
            return Product.Name + ", " + Product.Price.ToString("F2", CultureInfo.InvariantCulture) + "Quantity: " + Quantity + ", Subtotal: $" + SubTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
