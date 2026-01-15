using System;

class Program
{
    static void Main(string[] args)
    {
        string userInput;
        int userNumber;
        do
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display ");
            Console.WriteLine("3. Load ");
            Console.WriteLine("4. Save ");
            Console.WriteLine("5. Quit ");
            Console.Write("What would you like to do? ");
            userInput = Console.ReadLine();
            userNumber = int.Parse(userInput);
            if (userNumber == 1)
            {
                Console.WriteLine("Write Prompt");
            }
            else if (userNumber == 2)
            {
                Console.WriteLine("Display Prompt");
            }
            else if (userNumber == 3)
            {
                Console.WriteLine("Load Entry");
            }
            else if (userNumber == 4)
            {
                Console.WriteLine("Save Entry");
            }
            else if (userNumber == 5)
            {
                Console.WriteLine("Thank you, Goodbye.");
            }
            else
            {
                Console.WriteLine("Please enter a valid choice:");
            }
        } while (userNumber != 5);
        
    }
}