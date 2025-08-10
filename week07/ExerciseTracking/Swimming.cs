public class Swimming : Exercise
{
    private int _laps;

    public Swimming(string activity, int laps, int minutes, DateTime date) : base(activity, minutes, date)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        double distance = (double)_laps * 50 / 100;
        return distance;
    }

    public override double GetPace()
    {
        int minutes = GetMinutes();
        double pace = minutes / GetDistance();
        return pace;
    }

    public override double GetSpeed()
    {
        double speed = 60 / GetPace();
        return speed;
    }

    
}