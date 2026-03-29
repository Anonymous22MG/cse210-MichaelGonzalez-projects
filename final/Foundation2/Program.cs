using System;

class Program
{
    static void Main(string[] args)
    {
        // Order 1 (in USA)
        Address address1 = new Address("51 S 1st E", "Rexburg", "ID", "USA");
        Customer customer1 = new Customer("Michael Gonzalez", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Gaming Keyboard", "P700", 25.50, 1));
        order1.AddProduct(new Product("Razor Mouse", "P800", 20.75, 2));
        order1.AddProduct(new Product("MSI Monitor", "P900", 220.00, 1));

        // Order 2 (International)
        Address address2 = new Address("La Concepcion, Bugaba", "Chiriqui", "Panama", "04507");
        Customer customer2 = new Customer("Jonathan Zapata", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("HP Laptop", "P200", 450.50, 2));
        order2.AddProduct(new Product("Skullcandy Headphones", "P201", 32.00, 2));
        order2.AddProduct(new Product("Brita Filter Bottle", "P202", 22.25, 3));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalCost():F2}");
        Console.WriteLine("-----------------------------------");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalCost():F2}");
    }
}