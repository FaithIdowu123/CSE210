public class Cycling : Exercise
{
    public Cycling(string activity, int minutes, DateTime date) : base(activity, minutes, date)
    {

    }

    public override void CalculatePace()
    {
        double speed = GetSpeed();
        double pace = 60 / speed;
        SetPace(pace);
    }

    public override void CalculateDistance()
    {
        double pace = GetPace();
        int minutes = GetMinutes();
        double distance = minutes / pace;
        SetDistance(distance);
    }
}