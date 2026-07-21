using System;
using System.Collections.Generic;
using System.IO; 

public class Journal
{
    // Class properties
    public List<Entry> _userEntries = new List<Entry>();

    // Class methods
    public void AddEntry(Entry newEntry)
    {
        _userEntries.Add(newEntry);
    }
    public void DisplayJournal()
    {
        foreach (Entry entry in _userEntries)
        {
            entry.Display();
        }
    }
    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _userEntries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
            }
        }

        Console.WriteLine($"Journal saved successfully to {file}.");
    }
    public void LoadFromFile(string file)
    {
        if (File.Exists(file))
        {
            string[] lines = File.ReadAllLines(file);

            _userEntries.Clear();

            foreach (string line in lines)
            {
                string[] parts = line.Split("|");

                Entry entry = new Entry();

                entry._date = parts[0];
                entry._promptText = parts[1];
                entry._entryText = parts[2];

                _userEntries.Add(entry);
            }

            Console.WriteLine($"Journal loaded successfully from {file}.");
        }
        else
        {
            Console.WriteLine($"The file '{file}' was not found.");
        }
    }
}