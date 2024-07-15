using System;
using System.Collections.Generic;

namespace SupermarketSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize some sample products
            var products = new List<Product>
            {
                new PerishableProduct(1, 10.0m, 12.0m, "Milk", DateTime.Now.AddDays(7)),
                new NonPerishableProduct(2, 15.0m, 18.0m, "Canned Beans", 365)
            };

            // Initialize a store with these products
            var store = new Store(1, "SuperMart", products, new List<Transaction>());

            // Initialize a simulation
            var simulation = new Simulation(1, store, DateTime.Now, DateTime.Now.AddDays(30));

            // Run the simulation
            simulation.RunSimulation();

            // Output results
            Console.WriteLine("Simulation completed. KoleMart was [Profitable/Not Profitable] today.");
        }
    }
}
