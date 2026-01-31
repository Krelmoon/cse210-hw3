public class Order
{
    // attributes
    private List<Customer> _customers = new List<Customer>();
    private List<Product> _products = new List<Product>();

    // constructor
    public Order(Customer customer,Product product)
    {
        _customers.Add(customer);
        _products.Add(product);
    }

    // methods
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double CalculateTotalOrderCost()
    {
        double totalCost = 0;
        double shippingCost = 0;
        foreach (Product product in _products)
        {
            if (_customers[0].IsUSCustomer())
            {
                shippingCost = 5.0;
            }
            else
            {
                shippingCost = 35.0;
            }
            totalCost += product.GetTotalCost() + shippingCost;
        }
        return totalCost;
    }

    public string GetPackLabel()
    {
        string details = "Packing Label:\n";
        foreach (Product product in _products)
        {
            details += $"- {product.GetProductInfo()}\n";
        }
        return details;
    }
    public string GetShipLabel()
    {
        string details = "Shipping Label:\n";
        foreach (Customer customer in _customers)
        {
            details += $"{customer.GetCustomerInfo()}\n";
        }
        return details;
    }   
}   