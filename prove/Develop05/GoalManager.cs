using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
        Console.WriteLine($"Goal '{goal.GetName()}' added.");
    }

    public void RecordEvent(string goalName)
    {
        foreach (var goal in _goals)
        {
            if (goal.GetName().Equals(goalName, StringComparison.OrdinalIgnoreCase))
            {
                _score += goal.RecordEvent();
                Console.WriteLine($"Event recorded for goal '{goalName}'.");
                return;
            }
        }
        Console.WriteLine("Goal not found.");
    }

    public void DisplayGoals()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals to display.");
        }
        else
        {
            foreach (var goal in _goals)
            {
                Console.WriteLine(goal.Display());
            }
        }
    }

    public int GetScore() => _score;

    public void SaveGoals(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (var goal in _goals)
            {
                outputFile.WriteLine(goal.ToDataString());
            }
            outputFile.WriteLine($"Score:{_score}");
        }
        Console.WriteLine("Goals saved.");
    }

    public void LoadGoals(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string[] lines = File.ReadAllLines(filename);
        _goals.Clear();
        foreach (string line in lines)
        {
            if (line.StartsWith("SimpleGoal:"))
            {
                string[] parts = line.Substring(11).Split(',');
                SimpleGoal goal = new SimpleGoal(parts[0], int.Parse(parts[1]));
                goal.SetCompleted(bool.Parse(parts[2]));
                _goals.Add(goal);
            }
            else if (line.StartsWith("EternalGoal:"))
            {
                string[] parts = line.Substring(12).Split(',');
                EternalGoal goal = new EternalGoal(parts[0], int.Parse(parts[1]));
                _goals.Add(goal);
            }
            else if (line.StartsWith("ChecklistGoal:"))
            {
                string[] parts = line.Substring(14).Split(',');
                ChecklistGoal goal = new ChecklistGoal(parts[0], int.Parse(parts[1]), int.Parse(parts[2]), int.Parse(parts[3]));
                goal.SetCompleted(bool.Parse(parts[5]));
                _goals.Add(goal);
            }
            else if (line.StartsWith("Score:"))
            {
                _score = int.Parse(line.Substring(6));
            }
        }
        Console.WriteLine("Goals loaded.");
    }

    public void AddNewGoal()
    {
        Console.WriteLine("Enter goal type (1 - Simple, 2 - Eternal, 3 - Checklist): ");
        int goalType = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter goal name: ");
        string name = Console.ReadLine();

        Console.WriteLine("Enter goal points: ");
        int points = int.Parse(Console.ReadLine());

        switch (goalType)
        {
            case 1:
                AddGoal(new SimpleGoal(name, points));
                break;
            case 2:
                AddGoal(new EternalGoal(name, points));
                break;
            case 3:
                Console.WriteLine("Enter target count: ");
                int targetCount = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter bonus points: ");
                int bonusPoints = int.Parse(Console.ReadLine());
                AddGoal(new ChecklistGoal(name, points, targetCount, bonusPoints));
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                break;
        }
    }

    public void MarkGoalComplete()
    {
        Console.WriteLine("Enter the name of the goal to mark as complete: ");
        string name = Console.ReadLine().Trim();
        RecordEvent(name);
    }
}
