using System.Collections.Generic;

// Class representing a customer in the supermarket
public class Customer
{
    private int _customerID;  // Unique identifier for the customer
    private string _name;  // Name of the customer
    private List<Product> _shoppingCart;  // List of products in the customer's cart
    private string _preference;  // Customer's preference for product type

    public int CustomerID => _customerID;
    public string Name => _name;
    public List<Product> ShoppingCart => _shoppingCart;

    // Constructor to initialize a customer
    public Customer(int customerID, string name, string preference)
    {
        _customerID = customerID;
        _name = name;
        _shoppingCart = new List<Product>();
        _preference = preference;
    }

    // Adds a product to the customer's cart and reduces the product's stock
    public void AddToCart(Product product)
    {
        _shoppingCart.Add(product);
        product.ReduceStock(1);
    }

    // Calculates the total value of the products in the cart
    public decimal GetTotalCartValue()
    {
        decimal totalValue = 0;
        foreach (var product in _shoppingCart)
        {
            totalValue += product.CurrentPrice;
        }
        return totalValue;
    }

    // Returns the customer's preference
    public string GetPreference()
    {
        return _preference;
    }
}
