using System;

public class JournalEntry
{
    private string _prompt;
    private string _response;
    private DateTime _date;

    public JournalEntry()
    {
        _date = DateTime.Now;
    }

    public JournalEntry(string entryString)
    {
        // Assuming entryString format is "prompt|response|date"
        string[] parts = entryString.Split('|');
        _prompt = parts[0];
        _response = parts[1];
        _date = DateTime.Parse(parts[2]);
    }

    public void SetPrompt(string prompt)
    {
        _prompt = prompt;
    }

    public void SetResponse()
    {
        Console.WriteLine("Enter response:");
        _response = Console.ReadLine();
    }

    public void SetDate()
    {
        _date = DateTime.Now;
    }

    public override string ToString()
    {
        return $"Prompt: {_prompt}, Response: {_response}, Date: {_date}";
    }
}
