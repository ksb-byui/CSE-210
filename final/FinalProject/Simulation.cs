using System;
using System.Collections.Generic;
using System.Threading;

// Class representing the supermarket simulation
public class Simulation
{
    private int _simulationID;  // Unique identifier for the simulation
    private Store _store;  // Store being simulated
    private DateTime _startDate;  // Start date of the simulation
    private DateTime _endDate;  // End date of the simulation
    private List<string> _dailyReports;  // List to store daily reports

    // Constructor to initialize the simulation
    public Simulation(int simulationID, Store store, DateTime startDate, DateTime endDate)
    {
        _simulationID = simulationID;
        _store = store;
        _startDate = startDate;
        _endDate = endDate;
        _dailyReports = new List<string>();
    }

    // Runs the simulation for 10 days
    public void RunSimulation()
    {
        for (int i = 0; i < 10; i++)
        {
            // Simulate a day with a loading bar and time display
            TerminalAnimation.SimulateDay(10);

            // Simulate day in store
            _store.SimulateDay();

            // Generate daily report
            var report = GenerateDailyReport();
            TerminalAnimation.PrintDailyReport(report);

            // Store daily report for summary
            _dailyReports.Add(report);

            // Increment the day after each simulation run
            _store.IncrementDay();

            // Pause for 5 seconds
            Thread.Sleep(5000);
        }

        // Print 10-day summary
        PrintSummaryReport();
    }

    // Generates a daily report as a formatted string
    private string GenerateDailyReport()
    {
        var totalSales = 0m;
        var totalProductsSold = 0;

        foreach (var transaction in _store.Transactions)
        {
            totalSales += transaction.TotalAmount;
            totalProductsSold += transaction.Products.Count;
        }

        var netProfit = totalSales - _store.TotalExpenses;

        return $"**************************************************\n" +
               $"* Daily Report                                   *\n" +
               $"**************************************************\n" +
               $"Day: {_store.CurrentDay}\n" +
               $"Total Sales: ${totalSales}\n" +
               $"Total Transactions: {_store.Transactions.Count}\n" +
               $"Products Sold: {totalProductsSold}\n" +
               $"Total Expenses: ${_store.TotalExpenses}\n" +
               $"Net Profit: ${netProfit}\n" +
               $"Balance: ${_store.Balance}\n" +
               $"Restocks: {_store.RestockCount}\n" +
               $"**************************************************\n";
    }

    // Prints a report for 10 days simulated
    private void PrintSummaryReport()
    {
        decimal totalSales = 0;
        int totalTransactions = 0;
        int totalProductsSold = 0;
        decimal totalExpenses = 0;
        decimal totalNetProfit = 0;
        int totalRestocks = 0;

        foreach (var report in _dailyReports)
        {
            var lines = report.Split('\n');
            foreach (var line in lines)
            {
                if (line.StartsWith("Total Sales:"))
                {
                    totalSales += decimal.Parse(line.Split('$')[1]);
                }
                else if (line.StartsWith("Total Transactions:"))
                {
                    totalTransactions += int.Parse(line.Split(':')[1].Trim());
                }
                else if (line.StartsWith("Products Sold:"))
                {
                    totalProductsSold += int.Parse(line.Split(':')[1].Trim());
                }
                else if (line.StartsWith("Total Expenses:"))
                {
                    totalExpenses += decimal.Parse(line.Split('$')[1]);
                }
                else if (line.StartsWith("Net Profit:"))
                {
                    totalNetProfit += decimal.Parse(line.Split('$')[1]);
                }
                else if (line.StartsWith("Restocks:"))
                {
                    totalRestocks += int.Parse(line.Split(':')[1].Trim());
                }
            }
        }

        Console.WriteLine("**************************************************");
        Console.WriteLine("* 10-Day Summary                                 *");
        Console.WriteLine("**************************************************");
        Console.WriteLine($"Total Sales: ${totalSales}");
        Console.WriteLine($"Total Transactions: {totalTransactions}");
        Console.WriteLine($"Products Sold: {totalProductsSold}");
        Console.WriteLine($"Total Expenses: ${totalExpenses}");
        Console.WriteLine($"Net Profit: ${totalNetProfit}");
        Console.WriteLine($"Total Restocks: {totalRestocks}");
        Console.WriteLine("**************************************************");
    }
}
