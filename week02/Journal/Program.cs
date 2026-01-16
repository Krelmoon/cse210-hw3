using System;
// This is the main program for the Journal application
class Program
{
    // The main entry point of the program
    static void Main(string[] args)
    {
        // Create a new Journal instance
        Journal myJournal = new Journal();
        // Create a new Entry instance (not used further in this context)  
        Entry newEntry = new Entry(string.Empty, string.Empty);
        // Display the new entry (will be empty)
        newEntry.Display();
        // Create a PromptGenerator instance to get random prompts
        PromptGenerator promptGen = new PromptGenerator();
        // Variable declarations
        string userInput;
        int userNumber;
        string randomPrompt;
        // Main loop for user interaction
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
                // Get a random prompt and add a new entry to the journal
                randomPrompt = promptGen.GetRandomPrompt();
                    Console.WriteLine(randomPrompt);
                    Console.Write("> ");
                    userInput = Console.ReadLine();
                    myJournal.AddEntry(randomPrompt, userInput);
            }
            else if (userNumber == 2)
            {
                // Display all journal entries
                myJournal.DisplayAll();
            }
            else if (userNumber == 3)
            {
                // Load journal entries from a file
                myJournal.LoadFromFile("");
            }
            else if (userNumber == 4)
            {
                // Save journal entries to a file
                myJournal.SaveToFile("");
            }
            else if (userNumber == 5)
            {   
                // Exit the program
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