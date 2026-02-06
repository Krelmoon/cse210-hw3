public class ReflectingActivity : Activity
{   // List to store the prompts for the reflecting activity
    private List<string> _prompts = new List<string>();
    // List to store the questions for the reflecting activity
    private List<string> _questions = new List<string>();
    // Random object to generate random indices for prompts and questions
    public Random random = new Random{};
    // HashSet to track assigned prompt indices
    public HashSet<int> _assignedIndex = new HashSet<int>();
    // HashSet to track assigned question indices
    public HashSet<int> _assignedQuestionIndex = new HashSet<int>();

    // Constructor to set the name and description of the reflecting activity
    public ReflectingActivity()
    {
        SetName("Reflecting Activity");
        SetDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
    }
    // Method to run the reflecting activity
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
        Console.WriteLine("\nConsider the following prompt:");
        Console.WriteLine($"{GetRandomPrompt()}");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.WriteLine("You may begin in:");
        ShowCountDown(5);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine($"\n{GetRandomQuestion()}");
            ShowSpinner(10);
        }

        DisplayEndingMessage();
    }
    // Method to get a random prompt for the reflecting activity
    public string GetRandomPrompt()
        {   
            _prompts.Add("Think of a time when you felt truly at peace.");
            _prompts.Add("Think of a time when you overcame a challenge.");
            _prompts.Add("Think of a time when you stood up for someone else.");
            _prompts.Add("Think of a time when you did something really difficult.");
            _prompts.Add("Think of a time when you helped someone in need.");
            _prompts.Add("Think of a time when you did something truly selfless.");
            _prompts.Add("Think of a time when you made a positive impact on someone's life.");
            _prompts.Add("Think of a time when you achieved a personal goal.");
            _prompts.Add("Think of a time when you felt proud of yourself.");
            _prompts.Add("Think of a time when you learned something new about yourself.");
            _prompts.Add("Think of a time when you felt truly happy.");
            _prompts.Add("Think of a time when you experienced personal growth.");
            _prompts.Add("Think of a time when you faced a fear and conquered it.");
            _prompts.Add("Think of a time when you made a difficult decision.");
            _prompts.Add("Think of a time when you received unexpected kindness.");
            _prompts.Add("Think of a time when you felt truly connected to others.");
            

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
        // Method to get a random question for the reflecting activity
        public string GetRandomQuestion()
        {   
            _questions.Add("Why was this experience meaningful to you?");
            _questions.Add("Have you ever done anything like this before?");
            _questions.Add("How did you get started?");
            _questions.Add("How did you feel when it was complete?");
            _questions.Add("What made this time different than other times when you were not as successful?");
            _questions.Add("What is your favorite thing about this experience?");
            _questions.Add("What could you learn from this experience that applies to other situations?");
            _questions.Add("What did you learn about yourself through this experience?");
            _questions.Add("How can you keep this experience in mind in the future?");
            _questions.Add("What strengths did you exhibit during this experience?");
            _questions.Add("How can you apply what you learned from this experience to other areas of your life?");
            _questions.Add("What advice would you give to someone else about this experience?");
            _questions.Add("What emotions did you feel during this experience?");
            _questions.Add("How did this experience change your perspective?");
            _questions.Add("What would you do differently if you could relive this experience?");
            
            // to insure that questions are not assigned more than once each session
            int _questionsLen = _questions.Count;
            int _questionsIndex;

            do
            {
                _questionsIndex = random.Next(_questionsLen);
            } while (_assignedQuestionIndex.Contains(_questionsIndex));
            // loop that keeps going as long as _questionsIndex is in _assignedQuestionIndex
            
            // send the unassigned _questionsIndex to the hashset
            _assignedQuestionIndex.Add(_questionsIndex);
    
            return _questions[_questionsIndex];
        }
}