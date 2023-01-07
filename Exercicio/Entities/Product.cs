using System.Text;
using System.Globalization;
namespace Exercicio.Entities
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product()
        {
        }
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Name);
            sb.Append(", $");
            sb.Append(Price.ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
