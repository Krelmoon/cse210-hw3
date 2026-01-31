public class Address
{
    // attributes
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    // constructor
    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    // methods

    public bool IsUSAddress()
    {
        return _country.ToLower() == "usa" || _country.ToLower() == "us" || _country.ToLower() == "united states";
    }
    public string GetAddress()
    {
        return $"{_street}, {_city}, {_state} {_country}";
    }
}