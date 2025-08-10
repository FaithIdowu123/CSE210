public class Running : Exercise
{
    private double _distance;
    public Running(string activity, double distance, int minutes, DateTime date) : base(activity, minutes, date)
    {
        _distance = distance;
    }
    public override double GetDistance()
    {
        return _distance;
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