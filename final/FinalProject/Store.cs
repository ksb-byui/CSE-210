using System;
using System.Collections.Generic;
using System.IO;

// Class representing the supermarket store
public class Store
{
    private int _storeID;  // Unique identifier for the store
    private string _name;  // Name of the store
    private List<Product> _products;  // List of products available in the store
    private List<Transaction> _transactions;  // List of transactions in the store
    private decimal _totalExpenses;  // Total expenses of the store
    private decimal _balance;  // Current balance of the store
    private decimal _fixedCost = 300;  // Fixed operating cost of the store
    private int _currentDay;  // Current day of the simulation
    private int _restockThreshold = 20;  // Stock threshold for restocking
    private int _restockAmount = 50;  // Amount to restock
    private int _restockCount;  // Counter for restocking events

    // Constructor to initialize the store
    public Store(int storeID, string name, List<Product> products, List<Transaction> transactions)
    {
        _storeID = storeID;
        _name = name;
        _products = products;
        _transactions = transactions;
        LoadState();
    }

    public List<Transaction> Transactions => _transactions;
    public decimal TotalExpenses => _totalExpenses;
    public decimal Balance => _balance;
    public int CurrentDay => _currentDay;
    public int RestockCount => _restockCount;

    // Simulates a day in the store
    public void SimulateDay()
    {
        _restockCount = 0;  // Reset restock counter at the start of each day
        _transactions.Clear();  // Clear transactions at the start of each day

        var random = new Random();
        int numTransactions = random.Next(30, 50);
        _totalExpenses = _fixedCost;  // Start with the fixed cost

        for (int i = 0; i < numTransactions; i++)
        {
            string preference = random.Next(0, 2) == 0 ? "perishable" : "non-perishable";
            var customer = new Customer(i, $"Customer{i}", preference);
            int numProducts = random.Next(1, 10);
            for (int j = 0; j < numProducts; j++)
            {
                var product = GetProductByPreference(preference);
                if (product != null && product.Stock > 0)
                {
                    customer.AddToCart(product);
                    _totalExpenses += product.BasePrice * 0.5m;  // Assume 50% of base price is the cost
                }
            }
            var transaction = new Transaction(i, customer, customer.ShoppingCart, customer.GetTotalCartValue(), DateTime.Now);
            _transactions.Add(transaction);
            _balance += transaction.TotalAmount;
        }

        // Remove expired products
        RemoveExpiredProducts();

        // Restock products if needed
        RestockProducts();

        // Deduct total expenses from the balance
        _balance -= _totalExpenses;

        // Save the current state of the store
        SaveState();
    }

    // Adds a product to the store's inventory
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    // Retrieves a list of products based on customer preference
    public List<Product> GetProductsByPreference(string preference)
    {
        var preferredProducts = new List<Product>();
        foreach (var product in _products)
        {
            if ((preference == "perishable" && product is PerishableProduct) ||
                (preference == "non-perishable" && product is NonPerishableProduct))
            {
                preferredProducts.Add(product);
            }
        }
        return preferredProducts;
    }

    // Retrieves a random product based on customer preference
    public Product GetProductByPreference(string preference)
    {
        var preferredProducts = GetProductsByPreference(preference);
        if (preferredProducts.Count > 0)
        {
            var random = new Random();
            return preferredProducts[random.Next(preferredProducts.Count)];
        }
        return null;
    }

    // Removes expired products from the store's inventory
    public void RemoveExpiredProducts()
    {
        var currentDate = DateTime.Now;
        _products.RemoveAll(product => product is PerishableProduct perishable && perishable.CheckExpiration(currentDate));
    }

    // Restocks products
    public void RestockProducts()
    {
        foreach (var product in _products)
        {
            if (product.Stock < _restockThreshold)
            {
                product.Restock(_restockAmount);
                _totalExpenses += product.BasePrice * _restockAmount;  // Add restocking cost to expenses
                _restockCount++;
            }
        }
    }

    // Returns store details
    public string GetStoreDetails()
    {
        return $"StoreID: {_storeID}, Name: {_name}, Products: {_products.Count}, Transactions: {_transactions.Count}";
    }

    // Calculates daily profit for the store
    public decimal CalculateDailyProfit()
    {
        decimal totalSales = 0;
        foreach (var transaction in _transactions)
        {
            totalSales += transaction.TotalAmount;
        }
        return totalSales - _totalExpenses;
    }

    // Increments the current day of the simulation
    public void IncrementDay()
    {
        _currentDay++;
        SaveState();  // Save state after incrementing day
    }

    // Loads state of the store from a file
    private void LoadState()
    {
        try
        {
            if (File.Exists("store_state.txt"))
            {
                var lines = File.ReadAllLines("store_state.txt");
                _currentDay = int.Parse(lines[0]);
                _balance = decimal.Parse(lines[1]);
            }
            else
            {
                _currentDay = 1;
                _balance = 10000;  // Starting balance
            }
        }
        catch (Exception)
        {
            _currentDay = 1;
            _balance = 10000;
        }
    }

    // Saves current state of the store to a file
    private void SaveState()
    {
        try
        {
            File.WriteAllLines("store_state.txt", new string[]
            {
                _currentDay.ToString(),
                _balance.ToString()
            });
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving state: {ex.Message}");
        }
    }
}
