using System;
using System.Collections.Generic;

public class Journal
{
    // Class methods
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
}