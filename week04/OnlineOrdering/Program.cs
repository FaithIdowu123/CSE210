using System;

class Program
{
    static void Main(string[] args)
    {
        Product P1 = new Product("Bread", "FA1234", 20.90, 4);
        Product P2 = new Product("Milk", "FA2341", 15.70, 2);
        Product P3 = new Product("Meat", "FA3421", 40.20, 6);
        Product P4 = new Product("Fish", "FA9372", 30.20, 4);
        Product P5 = new Product("Onion", "FA2455", 20.59, 5);
        Product P6 = new Product("Tomato", "FA6732", 15.90, 8);

        List<Product> products1 = new List<Product>();
        products1.Add(P1);
        products1.Add(P2);
        products1.Add(P3);

        Address A1 = new Address("Navy estate", "Obada-Oko", "Ogun state", "Nigeria");
        Customer C1 = new Customer("Faith Idowu", A1);
        Order order1 = new Order(C1, products1);

        List<Product> products2 = new List<Product>();
        products2.Add(P4);
        products2.Add(P5);
        products2.Add(P6);

        Address A2 = new Address("Oke-Ata Housing Estate", "Abeokuta", "Ogun state", "USA");
        Customer C2 = new Customer("Isaiah Raph", A2);
        Order order2 = new Order(C2, products2);

        List<Product> products3 = new List<Product>();
        products3.Add(P1);
        products3.Add(P5);
        products3.Add(P3);

        Address A3 = new Address("Ajebo Road", "Abeokuta", "Ogun state", "Nigeria");
        Customer C3 = new Customer("Tise Ayo", A3);
        Order order3 = new Order(C3, products3);

        List<Order> orders = new List<Order>();
        orders.Add(order1);
        orders.Add(order2);
        orders.Add(order3);

        foreach (Order order in orders)
        {
            order.DisplayShippingLabel();
            Console.WriteLine("");
            Console.WriteLine("Order List: ");
            order.DisplayPackingLabel();
            Console.WriteLine("");
            double total = Math.Round(order.GetTotalCost(), 2);
            Console.WriteLine($"Total: ${total}");
            Console.WriteLine("");
        }
    }
}