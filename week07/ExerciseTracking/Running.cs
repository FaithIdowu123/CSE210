public class Running : Exercise
{
    public Running(string activity, int minutes, DateTime date) : base(activity, minutes, date)
    {

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