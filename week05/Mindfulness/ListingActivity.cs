using System.Runtime.InteropServices;

public class ListingActivity : Activity
{   
    // private variable to track the number of items listed by the user
    private int _count;
    // List to store the prompts for the listing activity
    private List<string> _prompts = new List<string>();
    public Random random = new Random{};
    // HashSet to track assigned prompt indices
    public HashSet<int> _assignedIndex = new HashSet<int>();
    // Constructor to set the name and description of the listing activity
    public ListingActivity()
    {
        SetName("Listing Activity");
        SetDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
    }
    // Method to run the listing activity
    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();
        _count = 0;
        string userInput;
        int userNumber;
        Console.WriteLine("How many minutes would you like to do this activity?");
        userInput = Console.ReadLine();
        userNumber = int.Parse(userInput);
        SetDuration(userNumber);
        Console.Clear();
        Console.WriteLine("Get ready to begin...");
        ShowSpinner(3);

        int duration = GetDuration();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddMinutes(duration);
        Console.Clear();
        Console.WriteLine("\nList as many responses as you can to the following prompt:");
        Console.WriteLine($"---{GetRandomPrompt()}---");
        Console.WriteLine("You may begin now!");


        while (startTime < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            _count += 1;
            startTime = DateTime.Now;
        }

        Console.WriteLine($"\nYou listed {_count} items!");
        DisplayEndingMessage();
    }
    // Method to get a random prompt for the listing activity
    public string GetRandomPrompt()
        {   
            _prompts.Add("Who are people that you appreciate?");
            _prompts.Add("What are personal strengths of yours?");
            _prompts.Add("Who are people that you have helped this week?");
            _prompts.Add("When have you felt the Holy Ghost this month?");
            _prompts.Add("Who are some of your personal heroes?");
            _prompts.Add("What are your favorite places to visit?");
            _prompts.Add("What are your favorite memories?");
            _prompts.Add("What are your favorite hobbies?");
            _prompts.Add("What are some things you are grateful for?");
            _prompts.Add("What are your favorite quotes?");
            _prompts.Add("What are some of your proudest accomplishments?");
            

            // to insure that prompts are not assigned more than once each session
            int _promptsLen = _prompts.Count;
            int _promptsIndex;

            do
            {
                _promptsIndex = random.Next(_promptsLen);
            } while (_assignedIndex.Contains(_promptsIndex));
            // loop that keeps going as long as _promptsIndex is in _assignedIndex
            
            // send the unassigned _promptsIndex to the hashset
            _assignedIndex.Add(_promptsIndex);
    
            return _prompts[_promptsIndex];
        }
}