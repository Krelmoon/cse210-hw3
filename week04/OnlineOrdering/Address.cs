public class Address
{
    // attributes
    private string _street;
    private string _city;
    private string _state;
    private string _zipCode;

    // constructor
    public Address(string street, string city, string state, string zipCode)
    {
        _street = street;
        _city = city;
        _state = state;
        _zipCode = zipCode;
    }

    // methods
    public string GetFullAddress()
    {
        return $"{_street}, {_city}, {_state} {_zipCode}";
    }
}