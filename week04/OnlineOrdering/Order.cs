public class Order
{
    // attributes
    private string _customerName;
    private string _shippingAddress;
    private List<Product> _products = new List<Product>();

    // constructor
    public Order(string customerName, string shippingAddress)
    {
        _customerName = customerName;
        _shippingAddress = shippingAddress;
    }

    // methods
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public string GetOrderDetails()
    {
        string details = $"Customer Name: {_customerName}\nShipping Address: {_shippingAddress}\nProducts:\n";
        foreach (Product product in _products)
        {
            details += $"- {product.GetProductInfo()}\n";
        }
        return details;
    }
}   