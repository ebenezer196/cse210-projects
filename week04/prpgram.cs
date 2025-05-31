using System;

namespace OnlineOrdering
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Addresses
            Address addr1 = new Address("123 Elm St", "Springfield", "IL", "USA");
            Address addr2 = new Address("456 Maple Ave", "Toronto", "ON", "Canada");

            // Create Customers
            Customer cust1 = new Customer("John Doe", addr1);
            Customer cust2 = new Customer("Jane Smith", addr2);

            // Create first order for John
            Order order1 = new Order(cust1);
            order1.AddProduct(new Product("Widget", "W123", 10.00, 2));
            order1.AddProduct(new Product("Gadget", "G456", 15.50, 1));

            // Create second order for Jane
            Order order2 = new Order(cust2);
            order2.AddProduct(new Product("Thingamajig", "T789", 7.25, 3));
            order2.AddProduct(new Product("Doohickey", "D012", 12.00, 2));
            order2.AddProduct(new Product("Whatchamacallit", "W345", 5.00, 5));

            // Display first order info
            Console.WriteLine("Order 1 Packing Label:");
            Console.WriteLine(order1.GetPackingLabel());

            Console.WriteLine("Order 1 Shipping Label:");
            Console.WriteLine(order1.GetShippingLabel());

            Console.WriteLine($"Order 1 Total Price: ${order1.CalculateTotalCost():0.00}");
            Console.WriteLine("-------------------------------------");

            // Display second order info
            Console.WriteLine("Order 2 Packing Label:");
            Console.WriteLine(order2.GetPackingLabel());

            Console.WriteLine("Order 2 Shipping Label:");
            Console.WriteLine(order2.GetShippingLabel());

            Console.WriteLine($"Order 2 Total Price: ${order2.CalculateTotalCost():0.00}");
        }
    }
}
