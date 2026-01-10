using System;

class Program
{
    static void Main(string[] args)
    {
        
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);
        int guess;
        do
        {
           Console.WriteLine("What is your guess? ");
            string userInput2 = Console.ReadLine();
            guess = int.Parse(userInput2);
            if (number > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (number < guess)
            {   
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            } 
        } while (number != guess);
        
    }
}