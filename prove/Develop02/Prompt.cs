using System;
using System.Collections.Generic;

public class Prompt
{
    private List<string> _promptsList;

    public Prompt()
    {
        // Initialize the list of prompts
        _promptsList = new List<string>() {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };
    }

    // Method to select a random prompt
    public string SelectRandomPrompt()
    {
        Random randomSelector = new Random();
        int promptIndex = randomSelector.Next(0, _promptsList.Count);
        return _promptsList[promptIndex];
    }
}
