public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonusPoints;  

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints) : base(name, description, points)
    {
        _targetCount = targetCount;
        _currentCount = 0;
        _bonusPoints = bonusPoints;
    }
    public ChecklistGoal(string name, string description, int points, int targetCount, int currentCount, int bonusPoints) : base(name, description, points)
    {
        _targetCount = targetCount;
        _currentCount = currentCount;
        _bonusPoints = bonusPoints;
    }
    public int GetBonusPoints()
    {
        return _bonusPoints;
    }
    public override void RecordEvent()
    {
        if (_currentCount < _targetCount)
        {
            _currentCount++;
        }
        else
        {
            Console.WriteLine("You have already completed this goal the required number of times. No additional points awarded.");
        }
    }

    public override bool IsComplete()
    {
        return _currentCount >= _targetCount;
    }

    public override string GetDetailsString()
    {
        return $"[{(IsComplete() ? "X" : " ")}] {GetName()} ({GetDescription()}) - Progress {_currentCount} of {_targetCount} - Points: {GetPoints()} - Bonus: {_bonusPoints}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{GetName()}|{GetDescription()}|{GetPoints()}|{_targetCount}|{_currentCount}|{_bonusPoints}";
    }
}