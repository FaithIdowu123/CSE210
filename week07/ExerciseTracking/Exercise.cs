using System.Globalization;

public abstract class Exercise
{
    private string _activity;
    private double _distance;
    private double _speed;
    private double _pace;
    private int _minutes;
    private DateTime _date;

    public Exercise(string activity, int minutes, DateTime date)
    {
        _activity = activity;
        _minutes = minutes;
        _date = date;
    }


    public void SetDistance(double distance)
    {
        _distance = distance;
    }

    public void SetSpeed(double speed)
    {
        _speed = speed;
    }

    public void SetPace(double pace)
    {
        _pace = pace;
    }

    public double GetDistance()
    {
        return _distance;
    }

    public double GetSpeed()
    {
        return _speed;
    }

    public double GetPace()
    {
        return _pace;
    }

    public int GetMinutes()
    {
        return _minutes;
    }

    public virtual void CalculateDistance()
    {
        
    }
    public virtual void CalculateSpeed()
    {
        
    }
    public virtual void CalculatePace()
    {
        
    }

    public void GetSummary()
    {
        double distance = Math.Round(_distance, 2);
        double speed = Math.Round(_speed, 2);
        double pace = Math.Round(_pace, 2);
        string date = _date.ToString("dd MMM yyyy", new CultureInfo("en-US"));
        Console.WriteLine($"{date} {_activity} ({_minutes}min) - Distance: {distance} km, Speed: {speed} kph, Pace: {pace} min per km");
    }

}