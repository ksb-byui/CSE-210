using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<JournalEntry> _entries;

    public Journal()
    {
        _entries = new List<JournalEntry>();
    }

    public void AddEntry(JournalEntry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayJournal()
    {
        foreach (var entry in _entries)
        {
            Console.WriteLine(entry.ToString());
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine(entry.ToString());
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        _entries.Clear();
        using (StreamReader reader = new StreamReader(filename))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                // Assuming each line in the file represents a journal entry
                var entry = new JournalEntry(line);
                _entries.Add(entry);
            }
        }
    }

    public List<JournalEntry> GetEntries()
    {
        return _entries;
    }
}
