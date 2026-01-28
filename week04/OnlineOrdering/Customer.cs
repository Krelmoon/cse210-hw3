public class Customer
{
    // attributes
    private string _name;
    private string _email;
    private string _phoneNumber;

    // constructor
    public Customer(string name, string email, string phoneNumber)
    {
        _name = name;
        _email = email;
        _phoneNumber = phoneNumber;
    }

    // methods
    public string GetCustomerInfo()
    {
        return $"Customer Name: {_name}\nEmail: {_email}\nPhone Number: {_phoneNumber}";
    }
    
}