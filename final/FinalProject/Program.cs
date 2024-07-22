using System;
using System.Collections.Generic;

// Main class to run the simulation
class Program
{
    static void Main(string[] args)
    {
        // Initialize common supermarket goods... and canned beans
        var products = new List<Product>
        {
            new PerishableProduct(1, 10.0m, 12.0m, "Milk", 100, DateTime.Now.AddDays(7)),
            new NonPerishableProduct(2, 15.0m, 18.0m, "Canned Beans", 200, 365),
            new PerishableProduct(3, 5.0m, 6.0m, "Bread", 150, DateTime.Now.AddDays(3)),
            new NonPerishableProduct(4, 20.0m, 25.0m, "Rice", 300, 365),
            new PerishableProduct(5, 2.0m, 3.0m, "Eggs", 200, DateTime.Now.AddDays(10)),
            new NonPerishableProduct(6, 1.0m, 1.5m, "Pasta", 400, 365),
            new NonPerishableProduct(7, 10.0m, 12.0m, "Detergent", 150, 365),
            new NonPerishableProduct(8, 8.0m, 10.0m, "Bleach", 150, 365),
            new NonPerishableProduct(9, 3.0m, 4.0m, "Sponges", 200, 365),
            new NonPerishableProduct(10, 5.0m, 6.0m, "Paper Towels", 300, 365)
        };

        // Initialize a store with these products
        var store = new Store(1, "KoleMart", products, new List<Transaction>());

        // Initialize a simulation
        var simulation = new Simulation(1, store, DateTime.Now, DateTime.Now.AddDays(30));

        // Run the simulation with animations
        simulation.RunSimulation();

        // End message
        Console.WriteLine("Simulation completed.");
    }
}
