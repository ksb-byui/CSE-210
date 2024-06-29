using System;

public class Program
{
    public static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        bool running = true;

        while (running)
        {
            Console.WriteLine("Select an option:");
            Console.WriteLine("1. Add New Goal");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. Display Goals");
            Console.WriteLine("4. Display Score");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Exit");

            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    goalManager.AddNewGoal();
                    break;
                case "2":
                    goalManager.MarkGoalComplete();
                    break;
                case "3":
                    goalManager.DisplayGoals();
                    break;
                case "4":
                    Console.WriteLine($"Score: {goalManager.GetScore()}");
                    break;
                case "5":
                    Console.WriteLine("Enter filename to save goals:");
                    string saveFilename = Console.ReadLine();
                    goalManager.SaveGoals(saveFilename);
                    break;
                case "6":
                    Console.WriteLine("Enter filename to load goals:");
                    string loadFilename = Console.ReadLine();
                    goalManager.LoadGoals(loadFilename);
                    break;
                case "7":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please select a valid option.");
                    break;
            }

            Console.WriteLine();
        }
    }
}


// To exceed requirements, I simply added a menu. I like easy and clean UI, especially in the terminal. While a menu might be a simple addition, it wasn't in the requirements and I feel that it makes my program much cleaner and easier to run and understand. The implementation of the menu also allows for a very customizable experience for the user. I don't have goal presets outside of the test .txt file which does not have to be loaded from for the program. The user starts with a blank page in my program and can use it as they please.