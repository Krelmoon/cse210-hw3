public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
    }

    public override void RecordEvent()
    {
        // Eternal goals are never completed, so we do nothing here.
    }

    public override bool IsComplete()
    {
        return false; // Eternal goals are never complete.
    }

    public override string GetDetailsString()
    {
        return $"[{(IsComplete() ? "X" : " ")}] {GetName()} ({GetDescription()}) - Points: {GetPoints()}";
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal|{GetName()}|{GetDescription()}|{GetPoints()}";
    }
}