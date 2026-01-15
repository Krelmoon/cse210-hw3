public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(string prompt, string userInput)
    {
        Entry newEntry = new Entry(prompt, userInput);
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
            {
                Console.WriteLine();
                Console.WriteLine(entry.Display());
            }
    }

    public void SaveToFile(string file)
    {
        
    }

    public void LoadFromFile(string file)
    {
        
    }
}