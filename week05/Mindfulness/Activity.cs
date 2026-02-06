public class Activity
{
    // Private variables to store the name, description, and duration of the activity
    private string _name;
    private string _description;
    private int _duration; // duration in minutes

    // Constructor to initialize the activity with default values
    public Activity()
    {
        _name = "Mindfulness Activity";
        _duration = 0;
    }
    // Method to display the starting message of the activity
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Starting {_name}.");
        Console.WriteLine(_description);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!");
        ShowSpinner(3);
        Console.WriteLine($"You have completed {_duration} minutes of the {_name}.");
        ShowSpinner(10);
    }
    public void ShowSpinner(int seconds)
    {
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        while (DateTime.Now < endTime)
        {
            foreach (char c in "|/-\\")
            {
                Console.Write(c);
                Thread.Sleep(250);
                Console.Write("\b");
            }
        }
    }
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    public void SetName(string name)
    {
        _name = name;
    }
    public void SetDuration(int duration)
    {
        _duration = duration;
    }
    public int GetDuration()
    {
        return _duration;
    }
    public void SetDescription(string description)
    {
        _description = description;
    }
}