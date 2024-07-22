using System;
using System.Collections.Generic;

// Class representing a transaction in the supermarket
public class Transaction
{
    private int _transactionID;  // Unique identifier for the transaction
    private Customer _customer;  // Customer involved in the transaction
    private List<Product> _products;  // List of products in the transaction
    private decimal _totalAmount;  // Total amount of the transaction
    private DateTime _date;  // Date of the transaction

    public int TransactionID => _transactionID;
    public decimal TotalAmount => _totalAmount;
    public List<Product> Products => _products;

    // Constructor to initialize a transaction
    public Transaction(int transactionID, Customer customer, List<Product> products, decimal totalAmount, DateTime date)
    {
        _transactionID = transactionID;
        _customer = customer;
        _products = products;
        _totalAmount = totalAmount;
        _date = date;
    }

    // Returns the details of the transaction
    public string GetTransactionDetails()
    {
        return $"TransactionID: {_transactionID}, Customer: {_customer.Name}, TotalAmount: {_totalAmount}, Date: {_date}";
    }
}
