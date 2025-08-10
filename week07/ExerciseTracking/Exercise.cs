using System.Globalization;

public abstract class Exercise
{
    private string _activity;
    private int _minutes;
    private DateTime _date;

    public Exercise(string activity, int minutes, DateTime date)
    {
        _activity = activity;
        _minutes = minutes;
        _date = date;
    }
 
    public int GetMinutes()
    {
        return _minutes;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        double distance = Math.Round(GetDistance(), 2);
        double pace = Math.Round(GetPace(), 2);
        double speed = Math.Round(GetSpeed(), 2);

        string date = _date.ToString("dd MMM yyyy", new CultureInfo("en-US"));
        string summary = $"{date} {_activity} ({_minutes}min) - Distance: {distance} km, Speed: {speed} kph, Pace: {pace} min per km";
        return summary;
    }

}