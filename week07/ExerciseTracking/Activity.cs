public abstract class Activity
{
    private string _date;
    private double _length;
    public Activity(double length)
    {
        _length = length;
    }
    public string GetDate()
    {
        DateTime currentDate = DateTime.Now;
        _date = currentDate.ToString("yyyy-MM-dd");
        return _date;
    }
    public double GetLength()
    {
        return _length;
    }
    public abstract double DisplayDistance();
    public abstract double DisplaySpeed();
    public abstract double DisplayPace();
    public abstract string DisplaySummary();
}