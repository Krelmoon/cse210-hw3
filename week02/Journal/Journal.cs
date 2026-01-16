using System.IO;
using System;
using System.Collections.Generic;
// Journal class to manage journal entries
public class Journal
{
    // List to store journal entries
    public List<Entry> _entries = new List<Entry>();

    // Method to add a new entry to the journal
    public void AddEntry(string prompt, string userInput)
    {
        Entry newEntry = new Entry(prompt, userInput);
        _entries.Add(newEntry);
    }

    // Method to display all journal entries
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
            {
                Console.WriteLine();
                Console.WriteLine(entry.Display());
            }
    }

    // Method to save journal entries to a file
    public void SaveToFile(string file)
    {
        Console.WriteLine("What is the filename? ");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}@@{entry._promptText}@@{entry._entryText}@@");
            }
        }
    }

    // Method to load journal entries from a file
    public void LoadFromFile(string file)
    {
        Console.WriteLine("What is the filename? ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split("@@");
            string date = parts[0].Replace("Date: ", "");
            string prompt = parts[1];
            string entryText = parts[2];
            Entry loadedEntry = new Entry(prompt, entryText);
            _entries.Add(loadedEntry);
        }
    }
}