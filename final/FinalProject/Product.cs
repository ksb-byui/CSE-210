namespace SupermarketSimulation
{
    public class Product
    {
        protected int _productID;
        protected decimal _basePrice;
        protected decimal _currentPrice;
        protected string _name;

        public Product(int productID, decimal basePrice, decimal currentPrice, string name)
        {
            _productID = productID;
            _basePrice = basePrice;
            _currentPrice = currentPrice;
            _name = name;
        }

        public void GenerateRandomPrice()
        {
            // Method implementation here
        }

        public string GetProductDetails()
        {
            // Method implementation here
            return string.Empty;
        }
    }
}
