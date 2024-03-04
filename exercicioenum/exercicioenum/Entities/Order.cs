using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exercicioenum.Entities.Enums;

namespace exercicioenum.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            this.Moment = moment;
            this.Status = status;
            this.Client = client;
           
        }

        public List<OrderItem> Ordems { get; set; } = new List<OrderItem>();
        public void AddContract(OrderItem contract)
        {
            Ordems.Add(contract);
        }

        public void RemoveContract(OrderItem contract)
        {
            Ordems.Remove(contract);
        }
        
        public double Total()
        {
            double sum = 0;
            foreach (OrderItem contract in Ordems)
            {

                sum += contract.subTotal() ;
                
            }
            return sum;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order Moment: " + Moment.ToString("dd/mm/yy HH:mm:ss"));
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine("Client: " + Client);
            sb.AppendLine("Order items:");
            foreach (OrderItem contract in Ordems)
            {
                sb.AppendLine(contract.ToString());
            }
            sb.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
