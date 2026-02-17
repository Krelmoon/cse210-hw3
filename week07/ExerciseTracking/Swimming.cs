public class Swimming : Activity
{
    private int _laps;
    public Swimming(double length, int laps) : base(length)
    {
        _laps = laps;
    }
    public override double DisplayDistance()
    {
        double distance = Math.Round(_laps * 50 / (1000 * 0.62), 1); // Distance in miles, rounded to 1 decimal place
        return distance; // Distance in miles, rounded to 1 decimal place
    }
    public override double DisplaySpeed()
    {
        double speed = Math.Round(DisplayDistance() / GetLength() * 60, 1); // Speed in miles per hour, rounded to 1 decimal place
        return speed; // Speed in miles per hour, rounded to 1 decimal place
    }
    public override double DisplayPace()
    {
        double pace = Math.Round(GetLength() / DisplayDistance(), 1);
        return pace; // Pace in minutes per mile, rounded to 1 decimal place   
    }
    public override string DisplaySummary()
    {
        return $"Swimming on {GetDate()} ({GetLength()} min) - Distance: {DisplayDistance():0.00} miles, Speed: {DisplaySpeed():0.00} mph, Pace: {DisplayPace():0.00} min/mile";
    }
}