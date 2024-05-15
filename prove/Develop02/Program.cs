using System;

public class Program
{
    private Journal journal;
    private Menu menu;

    public Program()
    {
        journal = new Journal();
        menu = new Menu(this);
    }

    public void Run()
    {
        menu.DisplayMenu();
    }

    public void AddEntry(JournalEntry entry)
    {
        journal.AddEntry(entry);
    }

    public void DisplayJournal()
    {
        journal.DisplayJournal();
    }

    public void SaveJournalToFile(string filename)
    {
        journal.SaveToFile(filename);
    }

    public void LoadJournalFromFile(string filename)
    {
        journal.LoadFromFile(filename);
    }

    static void Main(string[] args)
    {
        Program program = new Program();
        program.Run();
    }
}
