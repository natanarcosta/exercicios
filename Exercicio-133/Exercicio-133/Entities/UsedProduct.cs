using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Exercicio_133.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct()
        {

        }
        public UsedProduct(string name, double price, DateTime manufacturedate):base(name, price)
        {
            ManufactureDate = manufacturedate;
        }
        public sealed override string PriceTag()
        {
            return Name + " (used) + $" + Price.ToString("F2", CultureInfo.InvariantCulture) + " (Manufactre date: (" + ManufactureDate.ToString("dd/MM/yyyy") + ")";
        }
    }
}
