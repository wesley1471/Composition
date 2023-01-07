using System;
using System.Globalization;
using System.Text;
using Exercicio.Entities.Enums;

namespace Exercicio.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; } = DateTime.Now;
        public OrderStatus Status { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public Client Client { get; set; }

        public Order() { }

        public Order(OrderStatus status, Client client, DateTime moment)
        {
            Status = status;
            Client = client;
            Moment = moment;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }
        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }
        public double Total()
        {
            double sum = 0.0;
            foreach (OrderItem e in Items) 
            {
                sum += e.SubTotal();
            }
            return sum;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMMARY:");
            sb.Append("Order Moment: ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.Append("Order status: ");
            sb.AppendLine(Status.ToString());

            sb.AppendLine(Client.ToString());
            sb.AppendLine("Order items:");
            foreach(OrderItem e in Items)
            {
                sb.Append(e.ToString());
            }
            sb.Append("Total price: ");
            sb.Append(Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();


        }
    }
}
