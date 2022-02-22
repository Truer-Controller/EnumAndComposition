using System;
using EnumAndComposition.Entities.Enums;
using System.Globalization;
using EnumAndComposition.Entities;

namespace EnumAndComposition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data:");
            Console.Write("Name: ");
            string nameClient = Console.ReadLine();
            Console.Write("Email: ");
            string mailCliente = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Client clientRegister = new Client(nameClient, mailCliente, birthDate);

            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus statusOrder = Enum.Parse<OrderStatus>(Console.ReadLine());

            Order order = new Order(DateTime.Now, statusOrder, clientRegister);

            Console.Write("How many items to this order? ");
            int itemsOrder = int.Parse(Console.ReadLine());

            for(int i = 0; i < itemsOrder; i++)
            {
                Console.WriteLine($"Enter #{i+1} item data:");
                Console.Write("Product name: ");
                string nameProduct = Console.ReadLine();
                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int quantityProduct = int.Parse(Console.ReadLine());

                Product product = new Product(nameProduct, productPrice);

                OrderItem orderIrem = new OrderItem(quantityProduct, productPrice, product);
                order.AddItem(orderIrem);

            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order);

        }
    }
}
