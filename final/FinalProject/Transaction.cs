using System;
using System.Collections.Generic;

namespace SupermarketSimulation
{
    public class Transaction
    {
        private int _transactionID;
        private Customer _customer;
        private List<Product> _products;
        private decimal _totalAmount;
        private DateTime _date;

        public Transaction(int transactionID, Customer customer, List<Product> products, decimal totalAmount, DateTime date)
        {
            _transactionID = transactionID;
            _customer = customer;
            _products = products;
            _totalAmount = totalAmount;
            _date = date;
        }

        public void CompleteTransaction()
        {
            // Method implementation here
        }

        public string GetTransactionDetails()
        {
            // Method implementation here
            return string.Empty;
        }
    }
}
