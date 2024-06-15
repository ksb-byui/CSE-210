using System;
using System.Threading;

public abstract class Activity
{
    protected string Name;
    protected string Description;
    protected int Duration;

    public Activity(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public void Start()
    {
        Console.Clear();
        Console.WriteLine($"Starting {Name}...");
        Console.WriteLine(Description);
        Console.Write("Enter duration in seconds: ");
        Duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        Pause(3);
        RunActivity();
        Finish();
    }

    protected abstract void RunActivity();

    protected void Pause(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"\r{i} ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    protected void Spinner(int duration)
    {
        char[] spinner = { '|', '/', '-', '\\' };
        for (int i = 0; i < duration * 10; i++)
        {
            Console.Write($"\r{spinner[i % 4]} ");
            Thread.Sleep(100);
        }
        Console.WriteLine();
    }

    protected void Finish()
    {
        Console.WriteLine("Well done! ");
        Console.WriteLine($"You have completed the {Name} activity for {Duration} seconds.");
        Pause(3);
    }
}
