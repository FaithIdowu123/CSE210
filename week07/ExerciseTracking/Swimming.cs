public class Swimming : Exercise
{
    private int _laps;

    public Swimming(string activity, int laps, int minutes, DateTime date) : base(activity, minutes, date)
    {
        _laps = laps;
    }

    public override void CalculateDistance()
    {
        double distance = (double)_laps * 50 / 100;
        SetDistance(distance);
    }

    public override void CalculatePace()
    {
        int minutes = GetMinutes();
        double distance = GetDistance();
        double pace = minutes / distance;
        SetPace(pace);
    }

    public override void CalculateSpeed()
    {
        double pace = GetPace();
        double speed = 60 / pace;
        SetSpeed(speed);
    }
}