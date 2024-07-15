using System;
using System.Collections.Generic;

namespace SupermarketSimulation
{
    public class Customer
    {
        private int _customerID;
        private string _name;
        private List<Product> _shoppingCart;

        public Customer(int customerID, string name, List<Product> shoppingCart)
        {
            _customerID = customerID;
            _name = name;
            _shoppingCart = shoppingCart;
        }

        public void AddToCart(Product product)
        {
            // Method implementation here
        }

        public decimal GetTotalCartValue()
        {
            // Method implementation here
            return 0m;
        }
    }
}
