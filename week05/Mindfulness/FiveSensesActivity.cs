using System.Runtime.InteropServices;

public class FiveSensesActivty : Activity
{   
    // private variable to track the number of items listed by the user
    private int _count;
    // Constructor to set the name and description of the five senses activity
    public FiveSensesActivty()
    {
        SetName("Five Senses Activity");
        SetDescription("This activity will help you reflect on your surroundings in your life by having you list as many things as you can about the senses you can observe.");
    }
    // Method to run the Five Senses activity
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
        Console.WriteLine("\nList as many things as you can sense with one of your five senses from your surroundings as you can:");
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
    
}