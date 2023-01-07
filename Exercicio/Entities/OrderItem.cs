using System;
using Exercicio.Entities.Enums;
using System.Text;

namespace Exercicio.Entities
{
    internal class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }



        public OrderItem()
        {
        }

        public OrderItem(int quantity, Product product, double price)
        {
            Quantity = quantity;
            Product = product;
            Price= price;
        }

        public double SubTotal()
        {
            return Price * Quantity;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Product);
            sb.Append(", Quantity: ");
            sb.Append(Quantity);
            sb.Append(", Subtotal: $");
            sb.Append(SubTotal());
            return sb.ToString();
        }
    }
}
