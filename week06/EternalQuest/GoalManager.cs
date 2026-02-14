using System;
using System.Collections.Generic;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;
    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }
    public void Start()
    {
        // Variable to store user input for menu selection
        string userInput;
        // Variable to store the user's menu choice as a number
        int userNumber;
        // Do-while loop to display the menu and process user input until they choose to quit
        do
        {
            Console.WriteLine("");
            Console.WriteLine($"Your current score is: {_score}");
            Console.WriteLine("");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu? ");
            userInput = Console.ReadLine();
            userNumber = int.Parse(userInput);
            if (userNumber == 1)
            {
                CreateGoal();
            }
            else if (userNumber == 2)
            {
                DisplayPlayerInfo();
            }
            else if (userNumber == 3)
            {
                SaveGoals();
            }
            else if (userNumber == 4)
            {
                LoadGoals();
            }
            else if (userNumber == 5)
            {
                RecordEvent();
            }
            else if (userNumber == 6)
            {
                Console.WriteLine("Thank you, Goodbye.");
            }
            else
            {
                // Handle invalid input
                Console.WriteLine("Please enter a valid choice:");
            }
        } while (userNumber != 6);
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine("");
        Console.WriteLine($"Your current score is: {_score}");
        Console.WriteLine("");
        ListGoalDetails();
    }
    public void ListGoalDetails()
    {
        Console.WriteLine("Your Goals:");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }
    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal you would like to create?");
        string goalTypeInput = Console.ReadLine();
        int goalTypeNumber = int.Parse(goalTypeInput);
        if (goalTypeNumber == 1)
        {
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            int points = int.Parse(Console.ReadLine());
            SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
            _goals.Add(simpleGoal);
        }
        else if (goalTypeNumber == 2)
        {
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            int points = int.Parse(Console.ReadLine());
            EternalGoal eternalGoal = new EternalGoal(name, description, points);
            _goals.Add(eternalGoal);
        }
        else if (goalTypeNumber == 3)
        {
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            int points = int.Parse(Console.ReadLine());
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());
            ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
            _goals.Add(checklistGoal);
        }
        else
        {
            Console.WriteLine("Please enter a valid choice:");
        }
    }
    public void RecordEvent()
    {
        Console.WriteLine("Which goal did you accomplish?");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetName()}");
        }
        string goalInput = Console.ReadLine();
        int goalNumber = int.Parse(goalInput);
        if (goalNumber >= 1 && goalNumber <= _goals.Count)
        {
            Goal selectedGoal = _goals[goalNumber - 1];
            selectedGoal.RecordEvent();
            _score += selectedGoal.GetPoints();
            Console.WriteLine($"Congratulations! You earned {selectedGoal.GetPoints()} points.");
            Console.WriteLine($"Your new score is: {_score}");
            if (selectedGoal.IsComplete())
            {
                Console.WriteLine($"You have completed the goal: {selectedGoal.GetName()}!");
                if (selectedGoal is ChecklistGoal checklistGoal)
                {
                    if (checklistGoal.IsComplete())
                    {
                        _score += checklistGoal.GetPoints() + checklistGoal.GetBonusPoints();
                        Console.WriteLine($"Congratulations! You earned an additional {checklistGoal.GetBonusPoints()} bonus points for completing the checklist goal!");
                        Console.WriteLine($"Your new score is: {_score}");
                    }
                }
            }   
        }
        else
        {
            Console.WriteLine("Please enter a valid choice:");
        }
    }
    public void SaveGoals()
        {
            Console.WriteLine("What is the filename? ");
            string filename = Console.ReadLine();
            Console.WriteLine("Saving Goals...");
            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                outputFile.WriteLine(_score); // Save the current score at the beginning of the file
                foreach (Goal goal in _goals)
                {
                    outputFile.WriteLine(goal.GetStringRepresentation());
                }
            }
            Console.WriteLine("Goals Saved.");
        }
    public void LoadGoals()
        {
            Console.WriteLine("What is the filename? ");
            string filename = Console.ReadLine();
            Console.WriteLine("Loading Goals...");
            string[] lines = System.IO.File.ReadAllLines(filename);
            _goals.Clear(); // Clear existing goals before loading new ones
            _score = int.Parse(lines[0]); // Load the score from the first line of the file
            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split('|');
                string goalType = parts[0];
                if (goalType == "SimpleGoal")
                {
                    string name = parts[1];
                    string description = parts[2];
                    int simplePoints = int.Parse(parts[3]);
                    bool isComplete = bool.Parse(parts[4]);
                    SimpleGoal simpleGoal = new SimpleGoal(name, description, simplePoints);
                    if (isComplete)
                    {
                        simpleGoal.RecordEvent(); // Mark the goal as complete if it was saved as complete
                    }
                    _goals.Add(simpleGoal);
                }
                else if (goalType == "EternalGoal")
                {
                    string name = parts[1];
                    string description = parts[2];
                    int eternalPoints = int.Parse(parts[3]);
                    EternalGoal eternalGoal = new EternalGoal(name, description, eternalPoints);
                    _goals.Add(eternalGoal);
                }
                else if (goalType == "ChecklistGoal")
                {
                    string name = parts[1];
                    string description = parts[2];
                    int checklistPoints = int.Parse(parts[3]);
                    int targetCount = int.Parse(parts[4]);
                    int  currentCount = int.Parse(parts[5]);
                    int bonusPoints = int.Parse(parts[6]);
                    ChecklistGoal checklistGoal = new ChecklistGoal(name, description, checklistPoints, targetCount, currentCount, bonusPoints);
                    _goals.Add(checklistGoal);
                    
                }
            Console.WriteLine("Goals Loaded.");
        }
    }
}