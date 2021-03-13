using System;
using System.Collections.Generic;
using System.Text;

namespace _123_Exercicio.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        //Produto é criado no Program.cs e instanciado durante a criação de uma nova OrderItem 
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
