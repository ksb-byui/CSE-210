using System;
using System.Threading;

// Static class for terminal animation
public static class TerminalAnimation
{
    // Simulates a day with a loading bar and time display
    public static void SimulateDay(int seconds)
    {
        Console.WriteLine("Simulating a day from 8:00 AM to 6:00 PM:");
        int totalSteps = 50;
        int stepDuration = seconds * 20;

        DateTime startTime = new DateTime(1, 1, 1, 8, 0, 0);
        DateTime endTime = new DateTime(1, 1, 1, 18, 0, 0);
        TimeSpan timeIncrement = (endTime - startTime) / totalSteps;

        Console.Write("\rTime: 08:00 AM [                                                  ]");

        for (int i = 0; i < totalSteps; i++)
        {
            DateTime currentTime = startTime + (timeIncrement * i);
            Console.Write($"\rTime: {currentTime:hh:mm tt} [");
            Console.Write(new string('#', i + 1));
            Console.Write(new string(' ', totalSteps - i - 1));
            Console.Write("]");
            Thread.Sleep(stepDuration);
        }

        Console.Write($"\rTime: 06:00 PM [");
        Console.Write(new string('#', totalSteps));
        Console.Write("]\n");
    }

    // Prints the daily report to the terminal
    public static void PrintDailyReport(string report)
    {
        Console.WriteLine(report);
    }
}
