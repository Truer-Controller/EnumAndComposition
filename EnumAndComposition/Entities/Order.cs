using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using EnumAndComposition.Entities.Enums;

namespace EnumAndComposition.Entities
{
    class Order
    {
        public DateTime OrderMoment { get; set; }
        public OrderStatus StatusOrder { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> items { get; set; } = new List<OrderItem>();

        public Order()
        {
        }

        public Order(DateTime orderMoment, OrderStatus statusOrder, Client client)
        {
            OrderMoment = orderMoment;
            StatusOrder = statusOrder;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            items.Add(item);
        }
        public void Removeitem(OrderItem item)
        {
            items.Remove(item);
        }
        public double Total()
        {
            double sum = 0.0;
            foreach (OrderItem item in items)
            {
                sum += item.SubTotal();
            }
            return sum;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment: " + OrderMoment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + StatusOrder);
            sb.AppendLine("Client: " + Client);
            sb.AppendLine("Order items:");
            foreach (OrderItem item in items)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
