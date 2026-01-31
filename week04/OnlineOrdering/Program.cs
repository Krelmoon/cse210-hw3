using System;

class Program
{
    static void Main(string[] args)
    {
        Customer customer1 = new Customer("Jane Smith", new Address("456 Oak St", "Somecity", "TX", "USA"));
        Customer customer2 = new Customer("Akira Tanaka", new Address("789 Pine St", "Tokyo", "Kanta", "Japan"));
        Order order1 = new Order(customer1, new Product("Dell XPS 13","Laptop", 1200.00, 3));
        Order order2 = new Order(customer2, new Product("Sony WH-1000XM4","Headphones", 350.00, 2));
        Product product1 = new Product("ASUS 1313","Laptop", 999.99, 7);
        Product product2 = new Product("Razer Ana","Mouse", 25.50, 15);
        Product product3 = new Product("Logitech C920","Webcam", 70.00, 5);
        Product product4 = new Product("Apple Magic Keyboard","Keyboard", 99.00, 10);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);
        Console.WriteLine(order1.GetShipLabel());
        Console.WriteLine($"Total Order Cost: ${order1.CalculateTotalOrderCost()}");
        Console.WriteLine(order1.GetPackLabel());
        Console.WriteLine(order2.GetShipLabel());
        Console.WriteLine($"Total Order Cost: ${order2.CalculateTotalOrderCost()}");
        Console.WriteLine(order2.GetPackLabel());
        
    }
}