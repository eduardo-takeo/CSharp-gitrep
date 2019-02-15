using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowOrderItems.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product product { get; set; } = new Product();
        
        public OrderItem()
        {

        }

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            this.product = product;
        }

        public double subTotal()
        {
            double result = Price * Quantity;
            return result;
        }

        //TODO
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (OrderItem item in items)
            {
                sb.AppendLine($"{product.Name}, ${product.Price}, Quantity: {Quantity}, Subtotal: {subTotal()}");
            }            
            return sb.ToString();
        }
    }
}
