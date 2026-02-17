using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("This is the ExerciseTracking Project.");
        Cycling cyclingActivity = new Cycling(30, 10);
        Console.WriteLine(cyclingActivity.DisplaySummary());
        Running runningActivity = new Running(30, 6);
        Console.WriteLine(runningActivity.DisplaySummary());
        Swimming swimmingActivity = new Swimming(30, 10);
        Console.WriteLine(swimmingActivity.DisplaySummary());
    }
}