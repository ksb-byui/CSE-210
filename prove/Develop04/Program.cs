using System;

class Program
{
    static int completedActivities = 0;

    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine($"You have completed {completedActivities} activities.");
            Console.Write("Choose an activity: ");
            string choice = Console.ReadLine();

            Activity activity;
            switch (choice)
            {
                case "1":
                    activity = new BreathingActivity();
                    break;
                case "2":
                    activity = new ReflectionActivity();
                    break;
                case "3":
                    activity = new ListingActivity();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    Pause(3);
                    continue;
            }

            activity.Start();
            completedActivities++;
        }
    }

    static void Pause(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"\r{i} ");
            System.Threading.Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}
