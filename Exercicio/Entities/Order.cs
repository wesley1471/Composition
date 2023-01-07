using System;
using System.Text;
using Exercicio.Entities.Enums;

namespace Exercicio.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
    }
}
