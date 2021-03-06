﻿
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
    }
}
