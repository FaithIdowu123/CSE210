class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool InUSA()
    {
        bool answer = _address.IsUSA();
        return answer;
    }

    public string GetName()
    {
        return _name;
    }
    
    public Address GetAddress()
    {
        return _address;
    }
}