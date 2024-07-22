using System;

// Class representing a non-perishable product with a warranty period
public class NonPerishableProduct : Product
{
    private int _warrantyPeriod;  // Warranty period in months

    public int WarrantyPeriod => _warrantyPeriod;

    // Constructor to initialize a non-perishable product
    public NonPerishableProduct(int productID, decimal basePrice, decimal currentPrice, string name, int stock, int warrantyPeriod)
        : base(productID, basePrice, currentPrice, name, stock)
    {
        _warrantyPeriod = warrantyPeriod;
    }

    // Checks if the warranty is valid based on the purchase date and current date
    public bool CheckWarranty(DateTime purchaseDate, DateTime currentDate)
    {
        return purchaseDate.AddMonths(_warrantyPeriod) > currentDate;
    }

    // Returns product details
    public new string GetProductDetails()
    {
        return base.GetProductDetails() + $", WarrantyPeriod: {_warrantyPeriod} months";
    }
}
