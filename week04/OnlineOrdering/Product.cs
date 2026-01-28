public class Product
{
    // attributes
    private string _name;
    private string _productID;
    private double _price;
    private int _quantityInStock;

    // constructor
    public Product(string name, string productID, double price, int quantityInStock)
    {
        _name = name;
        _productID = productID;
        _price = price;
        _quantityInStock = quantityInStock;
    }

    // methods
    public string GetProductInfo()
    {
        return $"Product: {_name}\nProduct ID: {_productID}\nPrice: ${_price}\nQuantity in Stock: {_quantityInStock}";
    }

    public void UpdateStock(int quantitySold)
    {
        _quantityInStock -= quantitySold;
    }
    public double GetPrice()
    {
        return _price;
    }
}