using System;
using System.Globalization;
using exercicioenum.Entities;
using exercicioenum.Entities.Enums;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter order name: ");
            string orderName = Console.ReadLine();
           
            Console.WriteLine("Enter name Client: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter email Client: ");
            string email = Console.ReadLine();
            Console.WriteLine("Date of birth: ");
            Console.Write("DD/MM/YYYY): ");
            DateTime dateBirth = DateTime.Parse(Console.ReadLine());
            DateTime now = DateTime.Now;
            Console.Write("Order: (Pending_Payment, Processing, Shipped, Delivered): ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Client client = new Client(name, email, dateBirth);
            Order order = new Order(now, status, client);
            
            Console.WriteLine("Enter the quantity of items in the order:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Enter Product Name");
                string nameProduct = Console.ReadLine();
                Console.WriteLine("Enter Price Product");
                double priceProduct = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the purchase quantity for this item:");
                int quantPurchase = int.Parse(Console.ReadLine());
                OrderItem orderItem = new OrderItem(quantPurchase, priceProduct);
                Product product = new Product(nameProduct, priceProduct);
                order.AddContract(orderItem);
            }
            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order);


        }
    }
}