using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercicio123.Entities.Enum;

namespace Exercicio123.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public Client Client { get; set; }

        public Order()
        {

        }
        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem aquiItems)
        {
            Items.Add(aquiItems);
        }
        public void RemoveItem(OrderItem aquiItems)
        {
            Items.Remove(aquiItems);
        }

        public double Total() 
        {
            double sum = 0.0;   // Nao entendi essa linha
            foreach (OrderItem item in Items)   // Nao entendi essa linha
            {
                sum += item.SubTotal(); // Nao entendi essa linha
            }
            return sum; 
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine("Client: " + Client);
            sb.AppendLine("Order items:");
            foreach (OrderItem item in Items)   // Nao entendi essa linha
            {
                sb.AppendLine(item.ToString()); // Nao entendi essa linha
            }
            sb.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();   // Nao entendi essa linha

        }

    }
}
