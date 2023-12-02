public class Order
{
    private List<Product>_products;
    
    private Customer _customer; 

    public Order(List<Product>products,Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    public double GetTotalCost()
    {
        double total = _products.Sum(p => p.GetPrice());
        return total + (_customer.LivesInUSA() ? 5 : 35);
    }

    public string GetPackingLabel()
    {
        return string.Join("\n",_products.Select(p => $"{p.GetName()} - {p.GetId()}"));
    }

    public string GetShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetAddress()}";
    }
}