using System;

// Class representing a generic product in the supermarket
public class Product
{
    protected int _productID;  // Unique identifier for the product
    protected decimal _basePrice;  // Base price of the product
    protected decimal _currentPrice;  // Current selling price of the product
    protected string _name;  // Name of the product
    public int SalesCount { get; set; }  // Number of units sold
    public int Stock { get; set; }  // Amount available

    public int ProductID => _productID;
    public decimal BasePrice => _basePrice;
    public decimal CurrentPrice => _currentPrice;
    public string Name => _name;

    // Constructor to initialize a product
    public Product(int productID, decimal basePrice, decimal currentPrice, string name, int stock)
    {
        _productID = productID;
        _basePrice = basePrice;
        _currentPrice = currentPrice;
        _name = name;
        Stock = stock;
        SalesCount = 0;
    }

    // Generates a random current price based on base price
    public void GenerateRandomPrice()
    {
        var random = new Random();
        _currentPrice = _basePrice * (decimal)(random.NextDouble() * 0.4 + 0.8); // Price between 80% and 120% of base price
    }

    // Returns product details
    public string GetProductDetails()
    {
        return $"ProductID: {_productID}, Name: {_name}, CurrentPrice: {_currentPrice}, SalesCount: {SalesCount}, Stock: {Stock}";
    }

    // Reduces stock
    public void ReduceStock(int quantity)
    {
        Stock -= quantity;
    }

    // Increases stock
    public void Restock(int quantity)
    {
        Stock += quantity;
    }
}
