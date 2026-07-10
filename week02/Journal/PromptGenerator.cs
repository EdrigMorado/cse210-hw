using System;
using System.Collections.Generic;

public class PromptGenerator
{
    // Class properties
    public List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    // Class methods
    public string GetRandomPrompt()
    {
        // Create a new variable that generates random numbers named "random"
        Random random = new Random();
        // Creates a variable named "index" that will be = to a random number between 0 - (the total list pormpts -1)
        int index = random.Next(_prompts.Count);
        // returns the prompt of the random index generated before
        return _prompts[index];
    }
}