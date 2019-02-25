using System.Text;

namespace PriceTags.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {        
        }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public override string priceTag()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{Name} $ {Price} (Customs fee: $ {CustomsFee})");
            return sb.ToString();
        }
    }
}
