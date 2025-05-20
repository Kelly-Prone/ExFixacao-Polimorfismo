using System;
using Course.Entities;
using System.Globalization;


namespace Course.Entities
{
    internal class UsedProduct : Product
    {
        public DateTime ManifactureDate { get; set; }

        public UsedProduct() { }

        public UsedProduct(string name, double price, DateTime manifactureDate)
            :base(name, price)
        {
            ManifactureDate = manifactureDate;
        }

        public override string PriceTag()
        {
            return Name
                + "(used) $ "
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + " (Manufacture date: "
                + ManifactureDate.ToString("dd/MM/yyyy")
                + ")";
        }
    }
}
