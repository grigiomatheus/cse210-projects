using Foundation2.Models;

class Program
{
    static void Main(string[] args)
    {
        List<Order> orders = new List<Order>();
        
        Address address_1 = new Address("722 Elm Street", "Springfield", "OH", "USA");
        Customer customer_1 = new Customer("Luke Bryan", address_1);
        List<Product> products_1 = new List<Product>()
        {
            new Product("Chocolate Bar", "CB7250", 5, 2),
            new Product("Cola", "CL0058", 2.50, 3),
            new Product("Pop Corn", "PC1598", 15.0, 1)
        };

        orders.Add(new Order(customer_1, products_1));

        Address address_2 = new Address("51 Maple Avenue", "Greenville", "SC", "USA");
        Customer customer_2 = new Customer("Nate Smith", address_2);
        List<Product> products_2 = new List<Product>()
        {
            new Product("Potato Chips", "PC002512", 3, 5),
            new Product("Gummy Bears", "GB009807", 2.95, 7),
            new Product("Soda", "SD005873", 8.81, 2)
        };

        orders.Add(new Order(customer_2, products_2));

        Address address_3 = new Address("242 Rua das Maritacas", "Sao Paulo", "SP", "BR");
        Customer customer_3 = new Customer("José da Silva", address_3);
        List<Product> products_3 = new List<Product>()
        {
            new Product("Pretzels", "123PR", 2.59, 4),
            new Product("Granola Bars", "456GB", 5.38, 2),
            new Product("Cereal", "789CC", 6.64, 5)
        };

        orders.Add(new Order(customer_3, products_3));


        foreach (var order in orders)
        {
            Console.WriteLine("Shipping Label:");
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine();
            Console.WriteLine("Packing Label:");
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine($"Total Price: ${order.GetTotalPrice().ToString("#.##")}");
            Console.WriteLine("\n");
        }
    }
}