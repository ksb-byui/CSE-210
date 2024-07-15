using System;

namespace SupermarketSimulation
{
    public class PerishableProduct : Product
    {
        private DateTime _expirationDate;

        public PerishableProduct(int productID, decimal basePrice, decimal currentPrice, string name, DateTime expirationDate)
            : base(productID, basePrice, currentPrice, name)
        {
            _expirationDate = expirationDate;
        }

        public bool CheckExpiration()
        {
            // Method implementation here
            return false;
        }

        public new string GetProductDetails()
        {
            // Method implementation here
            return string.Empty;
        }
    }
}
