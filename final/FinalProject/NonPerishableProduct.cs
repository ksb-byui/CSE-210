namespace SupermarketSimulation
{
    public class NonPerishableProduct : Product
    {
        private int _warrantyPeriod;

        public NonPerishableProduct(int productID, decimal basePrice, decimal currentPrice, string name, int warrantyPeriod)
            : base(productID, basePrice, currentPrice, name)
        {
            _warrantyPeriod = warrantyPeriod;
        }

        public bool CheckWarranty()
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
