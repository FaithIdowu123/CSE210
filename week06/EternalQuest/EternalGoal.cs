public class EternalGoal : Goal
{

    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {

    }

    public override void RecordEvent()
    {
        iscomplete();
    }

    public override bool iscomplete()
    {
        return false;
    }


    public override string GetSaveableString()
    {
        return $"EternalGoal:{GetName()}|{GetDescription()}|{GetPoints()}";
    }
}