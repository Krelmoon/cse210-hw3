using System;

class Program
{
    static void Main(string[] args)
    {
        // Variable to store user input for menu selection
        string userInput;
        // Variable to store the user's menu choice as a number
        int userNumber;
        // Do-while loop to display the menu and process user input until they choose to quit
        do
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Start five senses survey");
            Console.WriteLine("5. Quit");
            Console.Write("Select a choice from the menu? ");
            userInput = Console.ReadLine();
            userNumber = int.Parse(userInput);
            if (userNumber == 1)
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Run();
            }
            else if (userNumber == 2)
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.Run();
            }
            else if (userNumber == 3)
            {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.Run();
            }
            else if (userNumber == 4)
            {
                FiveSensesActivty fiveSensesActivty = new FiveSensesActivty();
                fiveSensesActivty.Run();
            }
            else if (userNumber == 5)
            {
                Console.WriteLine("Thank you, Goodbye.");
            }
            else
            {
                // Handle invalid input
                Console.WriteLine("Please enter a valid choice:");
            }
        } while (userNumber != 5);    
    }
}