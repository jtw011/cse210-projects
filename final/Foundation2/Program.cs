using System;

class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product("Product 1", 1, 10.0,2);
        Product product2 = new Product("Product 2", 2, 20.0,1);

        Address address = new Address("123 Main St", "Rexburg", "Idaho", "USA");

        Customer customer = new Customer("John Doe", address);

        List<Product> products = new List<Product> { product1, product2 };

        Order order = new Order(products, customer);

        Console.WriteLine($"Total Cost: {order.GetTotalCost()}");
        Console.WriteLine($"PackingLabel: {order.GetPackingLabel()}");
        Console.WriteLine($"Shipping Label: {order.GetShippingLabel(  )}");

    }
}