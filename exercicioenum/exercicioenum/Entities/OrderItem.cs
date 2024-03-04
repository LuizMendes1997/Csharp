using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioenum.Entities
{
    internal class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }    
        public OrderItem(int quantity, double price, Product product)
        {
            this.Quantity = quantity;
            Price = price;
            Product = product;
        }
        public OrderItem()
        {
             }
      
        public double subTotal()
        {
            return Price * Quantity;
        }
        public override string ToString()
        {
            return  Price
                + ", Quantity: "
                + Quantity
                + ", Subtotal: $"
                + subTotal();
        }
    }
}
