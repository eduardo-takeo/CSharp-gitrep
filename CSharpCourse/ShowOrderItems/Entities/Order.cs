using ShowOrderItems.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShowOrderItems.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> items { get; set; } = new List<OrderItem>();
        public Client client { get; set; } = new Client();

        public Order()
        {

        }
        
        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            this.client = client;
        }

        public void addItem(OrderItem item)
        {
            items.Add(item);
        }

        public void removeItem(OrderItem item)
        {
            items.Remove(item);
        }
        
        public double total()
        {
            double totalValue = 0;
            foreach (OrderItem item in items)
            {
                totalValue += item.subTotal();               
            }
            return totalValue;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment: " + Moment);
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine($"{client.Name} ({client.BirthDate}) - {client.Email}");
            sb.AppendLine("Order items: ");
            foreach (OrderItem item in items)
            {
                sb.AppendLine($"{item.product.Name}, ${item.product.Price}, Quantity: {item.Quantity}, Subtotal: ${item.subTotal()}");
            }                       
            sb.AppendLine($"Total price: ${total().ToString()}");
            return sb.ToString();
        }
    }
}
