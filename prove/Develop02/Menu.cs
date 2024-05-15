using System;

public class Menu
{
    private Program program;

    public Menu(Program program)
    {
        this.program = program;
    }

    public void DisplayMenu()
    {
        Console.WriteLine("Menu:");
        Console.WriteLine("1. Write a new entry");
        Console.WriteLine("2. Display the journal");
        Console.WriteLine("3. Save the journal to a file");
        Console.WriteLine("4. Load the journal from a file");
        Console.WriteLine("5. Exit");

        int choice = GetUserChoice();
        ExecuteAction(choice);
    }

    public int GetUserChoice()
    {
        Console.WriteLine("Enter your choice:");
        return int.Parse(Console.ReadLine());
    }

    public void ExecuteAction(int choice)
    {
        switch (choice)
        {
            case 1:
                WriteNewEntry();
                break;
            case 2:
                DisplayJournal();
                break;
            case 3:
                SaveJournalToFile();
                break;
            case 4:
                LoadJournalFromFile();
                break;
            case 5:
                Console.WriteLine("Exiting program...");
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Invalid choice. Please enter a number from 1 to 5.");
                break;
        }
    }

    public void WriteNewEntry()
    {
        JournalEntry newEntry = new JournalEntry();
        Prompt prompt = new Prompt(); // Create a new instance of Prompt
        newEntry.SetPrompt(prompt.SelectRandomPrompt());  // Set prompt
        newEntry.SetResponse();  // Set response
        newEntry.SetDate();  // Set date
        program.AddEntry(newEntry);  // Add entry to journal
    }

    public void DisplayJournal()
    {
        program.DisplayJournal();
    }

    public void SaveJournalToFile()
    {
        Console.WriteLine("Enter the filename to save the journal to:");
        string filename = Console.ReadLine();
        program.SaveJournalToFile(filename);
    }

    public void LoadJournalFromFile()
    {
        Console.WriteLine("Enter the filename to load the journal from:");
        string filename = Console.ReadLine();
        program.LoadJournalFromFile(filename);
    }
}
