using System;
using System.Text;

namespace PriceTags.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price, DateTime manufactureDate) : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string priceTag()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{Name} (used) $ {Price} (Manufacture date: {ManufactureDate})");
            return sb.ToString();
        }
    }
}
