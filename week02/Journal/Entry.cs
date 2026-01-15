// generates an entry
public class Entry
{
    public DateTime _date;
    public string _promptText;
    public string _entryText;
    public Entry(string prompt, string userInput)
    {
        _promptText = prompt;
        _entryText = userInput;
        _date = DateTime.Now;
    }

    public string Display()
    {
        return $"Date: {_date} - {_promptText}\n{_entryText}";
    }

}