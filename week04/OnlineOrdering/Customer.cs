public class Customer
{
    // attributes
    private string _name;
    private Address _address;

    // constructor
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    // methods
    public bool IsUSCustomer()
    {
        return _address.IsUSAddress();
    }
    public string GetCustomerInfo()
    {
        return $"Customer Name: {_name}\nAddress: {_address.GetAddress()}";
    }
    
}