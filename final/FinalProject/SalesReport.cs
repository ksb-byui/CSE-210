using System;
using System.Collections.Generic;

namespace SupermarketSimulation
{
    public class SalesReport
    {
        private int _reportID;
        private List<Transaction> _transactions;
        private DateTime _dateGenerated;

        public SalesReport(int reportID, List<Transaction> transactions, DateTime dateGenerated)
        {
            _reportID = reportID;
            _transactions = transactions;
            _dateGenerated = dateGenerated;
        }

        public string GenerateReport()
        {
            // Method implementation here
            return string.Empty;
        }

        public string GetReportDetails()
        {
            // Method implementation here
            return string.Empty;
        }
    }
}
