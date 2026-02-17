public class Cycling : Activity
{
    private double _speed;
    public Cycling(double length, double speed) : base(length)
    {
        _speed = speed;
    }
    public override double DisplayDistance()
    {
        double distance = Math.Round(GetLength() * _speed / 60, 1); // Distance in miles, rounded to 1 decimal place
        return distance; // Distance in miles, rounded to 1 decimal place
    }
    public override double DisplaySpeed()
    {
        return Math.Round(_speed, 1); // Speed in miles per hour, rounded to 1 decimal place
    }
    public override double DisplayPace()
    {
        double pace = Math.Round(60 / _speed, 1);
        return pace; // Pace in minutes per mile, rounded to 1 decimal place   
    }
    public override string DisplaySummary()
    {
        return $"Cycling on {GetDate()} ({GetLength()} min) - Distance: {DisplayDistance():0.00} miles, Speed: {DisplaySpeed():0.00} mph, Pace: {DisplayPace():0.00} min/mile";
    }
}