// generates an entry
public class Entry
{
    // entry attributes
    public DateTime _date;
    public string _promptText;
    public string _entryText;

    // constructor
    public Entry(string prompt, string userInput)
    {
        _promptText = prompt;
        _entryText = userInput;
        _date = DateTime.Now;
    }

    // method to display entry
    public string Display()
    {
        return $"Date: {_date} - {_promptText}\n{_entryText}";
    }

}