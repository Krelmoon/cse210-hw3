using System;

class Program
{
    static void Main(string[] args)
    {
        Customer customer = new Customer("Jane Smith", "Google@gmail.com", "555-1234");
        Address address = new Address("123 Main St", "Anytown", "CA", "12345");
        Order order = new Order("John Doe", "123 Main St, Anytown, USA");
        Product product1 = new Product("ASUS 1313","Laptop", 999.99, 7);
        Product product2 = new Product("Razer Ana","Mouse", 25.50, 15);
        order.AddProduct(product1);
        order.AddProduct(product2);
        Console.WriteLine(order.GetOrderDetails());
    }
}