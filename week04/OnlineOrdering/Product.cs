public class Product
{
    // attributes
    private string _name;
    private string _productID;
    private double _price;
    private int _quantityToOrder;

    // constructor
    public Product(string name, string productID, double price, int quantityToOrder)
    {
        _name = name;
        _productID = productID;
        _price = price;
        _quantityToOrder = quantityToOrder;
    }

    // methods
    public string GetProductInfo()
    {
        return $"Product: {_name}\nProduct ID: {_productID}\nPrice: ${_price}\nQuantity To Order: {_quantityToOrder}";
    }
    public double GetTotalCost()
    {
        return _price * _quantityToOrder;
    }
}