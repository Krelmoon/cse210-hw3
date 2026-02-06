public class ListingActivity : Activity
{   
    private int _count;
    private List<string> _prompts = new List<string>();
    public Random random = new Random{};
    // HashSet to track assigned prompt indices
    public HashSet<int> _assignedIndex = new HashSet<int>();
    
    public ListingActivity()
    {
        SetName("Listing Activity");
        SetDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
    }

    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();
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
        DateTime endTime = DateTime.Now.AddMinutes(duration);
        Console.Clear();
        Console.WriteLine("\nList as many responses as you can to the following prompt:");
        Console.WriteLine($"{GetRandomPrompt()}");
        Console.WriteLine("You may begin now!");

        int itemCount = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            if (!string.IsNullOrEmpty(response))
            {
                itemCount++;
            }
        }

        Console.WriteLine($"\nYou listed {itemCount} items!");
        DisplayEndingMessage();
    }
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