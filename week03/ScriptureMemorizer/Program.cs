using System;

class Program
{
    static void Main(string[] args)
    {
        
        // Initialize scripture memorizer
        Console.Clear();
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(reference, "Trust in the Lord with all your heart and lean not on your own understanding;");
        // Main loop
        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("\nAll words are hidden. Well done!");
                break;
            }
            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit:");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                break;
            }
            scripture.HideRandomWords(3);
        }
    }
}