using System;
using System.Collections.Generic;
using System.Text;
using _123_Exercicio.Entities.Enums;
using System.Globalization;

namespace _123_Exercicio.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }

        public List<OrderItem> Items = new List<OrderItem>();

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }
        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }
        public void RemoteItem(OrderItem item)
        {
            Items.Remove(item);
        }
        public double Total()
        {
            double total = 0;
            foreach (OrderItem x in Items)
            {
                total += x.SubTotal();
            }
            return total;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("ORDER SUMMARY:");
            sb.AppendLine(Moment.ToString());
            sb.AppendLine(Status.ToString());
            sb.Append(Client.Name + " ");
            sb.Append("("+Client.BirthDate.ToString("dd/MM/yyyy")+")");
            sb.Append(" - ");
            sb.AppendLine(Client.Email);
            sb.AppendLine("Order items:");
            foreach(OrderItem x in Items)
            {
                sb.AppendLine(x.Product.Name + ", $" + x.Price + ", Quantity: " + x.Quantity + ", Subtotal: $" + x.SubTotal().ToString("F2", CultureInfo.InvariantCulture));
            }
            sb.Append("Total price: $");
            sb.Append(Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }

    }
}
