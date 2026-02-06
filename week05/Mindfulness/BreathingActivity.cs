public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        SetName("Breathing Activity");
        SetDescription("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
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

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("\nBreathe in...");
            ShowCountDown(4);
            Console.WriteLine("\nBreathe out...");
            ShowCountDown(6);
        }

        DisplayEndingMessage();
    }
}