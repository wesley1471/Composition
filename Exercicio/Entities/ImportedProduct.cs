using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;


namespace Exercicio.Entities
{
    internal class ImportedProduct : Product
    {
        public double CustumsFee { get; set; }
        public ImportedProduct() 
        {
        }

        public ImportedProduct(string name, double price , double custumsFee):base (name, price)
        {
            CustumsFee = custumsFee;
        }
        public override string PriceTag()
        {
            TotalPrice();
            StringBuilder sb = new StringBuilder();
            sb.Append(Name);
            sb.Append(" $ ");
            sb.Append(TotalPrice().ToString("F2", CultureInfo.InvariantCulture) + "(Customs fee: $ " + CustumsFee.ToString("F2", CultureInfo.InvariantCulture) + ")");
            return sb.ToString();
        }

        public double TotalPrice()
        {
            return Price + CustumsFee;
        }
    }
}
