using System;

public class Entry
{
    // Class properties
    public string _date;
    public string _promptText;
    public string _entryText;

    // Class methods
    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine(_entryText);
        Console.WriteLine();
    }
}