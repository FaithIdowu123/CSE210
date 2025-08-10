public class Cycling : Exercise
{
    private double _speed;
    
    public Cycling(string activity, double speed, int minutes, DateTime date) : base(activity, minutes, date)
    {
        _speed = speed;
    }

    public override double GetSpeed()
    {
        return _speed;
    }


    public override double GetPace()
    {
        double pace = 60 / GetSpeed();
        return pace;
    }

    public override double GetDistance()
    {
        int minutes = GetMinutes();
        double distance = minutes / GetPace();
        return distance;
    }
}