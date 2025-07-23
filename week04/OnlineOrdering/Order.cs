class Order
{
    private Customer _customer;
    private List<Product> _products = new List<Product>();

    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        foreach (Product product in products)
        {
            _products.Add(product);
        }
    }

    public double GetTotalCost()
    {
        double total = 0;
        foreach (Product product in _products)
        {
            double cost = product.TotalPrice();
            total += cost;
        }
        if (_customer.InUSA())
        {
            total += 35;
        }
        else
        {
            total += 5;
        }
        return total;
    }

    public void DisplayPackingLabel()
    {
        foreach (Product product in _products)
        {
            string name = product.GetName();
            string productId = product.GetProductId();
            Console.WriteLine($"{productId}-{name}");
        }
    }

    public void DisplayShippingLabel()
    {
        Console.WriteLine(_customer.GetName());
        Address address = _customer.GetAddress();
        Console.WriteLine($"{address.GetFullAddress()}");
    }
}