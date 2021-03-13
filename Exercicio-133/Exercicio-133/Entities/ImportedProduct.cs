using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Exercicio_133.Entities
{
    class ImportedProduct : Product
    {
        public double CustomFee { get; set; }

        public ImportedProduct()
        {

        }
        public ImportedProduct(string name, double price, double customfee) : base (name, price)
        {
            CustomFee = customfee;
        }
        public double TotalPrice()
        {
            return Price + CustomFee;
        }
        public sealed override string PriceTag()
        {
            return Name + " $ " + TotalPrice().ToString("F2", CultureInfo.InvariantCulture) + " (Customs fee: $" + CustomFee.ToString("F2", CultureInfo.InvariantCulture) + ")";
        }
    }
}
