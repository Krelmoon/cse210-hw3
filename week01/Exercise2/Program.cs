using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);
        string letter = ("F");
        string sign = (" ");
        if (grade >= 90)
        {
            letter = ("A");
        }
        else if (grade >= 80)
        {
            letter = ("B");
        }
        else if (grade >= 70)
        {
            letter = ("C");
        }
        else if (grade >= 60)
        {
            letter = ("D");
        }
        else if (grade < 60)
        {
            letter = ("F");
        }
        int remainder = (grade % 10);
        if (remainder >= 7 && grade < 97 && grade >= 60)
        {
            sign = ("+");
        }
        else if (remainder <=3 && grade >= 60)
        {
            sign = ("-");
        }
        else
        {
            sign = (" ");
        }
        Console.WriteLine($"Your grade is {letter}{sign} ");
        if (grade > 70)
        {
            Console.WriteLine("Congratulations, you passed!");
        }
        else
        {
            Console.WriteLine("Try harder next time.");
        }
    }
}