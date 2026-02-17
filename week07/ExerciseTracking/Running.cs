public class Running : Activity
{
    private double _distance;
    public Running(double length, double distance) : base(length)
    {
        _distance = distance;
    }

    public override double DisplayDistance()
    {
        return Math.Round(_distance, 1); // Distance in miles, rounded to 1 decimal place
    }

    public override double DisplaySpeed()
    {
        double speed = Math.Round(DisplayDistance() / GetLength() * 60, 1); // Speed in miles per hour, rounded to 1 decimal place
        return speed; // Speed in miles per hour, rounded to 1 decimal place
    }

    public override double DisplayPace()

    {
        double pace = Math.Round(GetLength() / DisplaySpeed(), 1);
        return pace; // Pace in minutes per mile, rounded to 1 decimal place
    }

    public override string DisplaySummary()
    {
        return $"Running on {GetDate()} ({GetLength()} min) - Distance: {DisplayDistance():0.00} miles, Speed: {DisplaySpeed():0.00} mph, Pace: {DisplayPace():0.00} min/mile";
    }
}