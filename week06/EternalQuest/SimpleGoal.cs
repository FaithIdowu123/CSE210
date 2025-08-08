public class SimpleGoal : Goal
{
    private bool _iscomplete = false;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {

    }

    public override void RecordEvent()
    {
        _iscomplete = true;
    }

    public override bool iscomplete()
    {
        return _iscomplete;
    }


    public override string GetSaveableString()
    {
        return $"SimpleGoal:{GetName()}|{GetDescription()}|{GetPoints()}|{_iscomplete}";
    }

    public override bool GetComplete()
    {
        return _iscomplete;
    }

}