using System;

// Class representing a perishable product with an expiration date
public class PerishableProduct : Product
{
    private DateTime _expirationDate;  // Expiration date of the product

    public DateTime ExpirationDate => _expirationDate;

    // Constructor to initialize a perishable product
    public PerishableProduct(int productID, decimal basePrice, decimal currentPrice, string name, int stock, DateTime expirationDate)
        : base(productID, basePrice, currentPrice, name, stock)
    {
        _expirationDate = expirationDate;
    }

    // Checks if the product is expired based on the current date
    public bool CheckExpiration(DateTime currentDate)
    {
        return currentDate > _expirationDate;
    }

    // Returns product details including expiration date
    public new string GetProductDetails()
    {
        return base.GetProductDetails() + $", ExpirationDate: {_expirationDate.ToShortDateString()}";
    }
}
