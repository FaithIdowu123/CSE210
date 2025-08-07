using System.Drawing;

public class CheckListGoal : Goal
{
    private int _amountCompleted = 0;
    private int _bonus;
    private int _target;
    private bool _completed = false;

    public CheckListGoal(string name, string description, int points, int bonus, int target) : base(name, description, points)
    {
        _bonus = bonus;
        _target = target;
    }

    public override void RecordEvent()
    {
        if (_target > _amountCompleted)
        {
            _amountCompleted++;
            if (_target == _amountCompleted)
            {
                _completed = iscomplete();
            }
        }
    }

    public override bool iscomplete()
    {
        return true;
    }

    public override string GetDetails()
    {
        if (_target == _amountCompleted)
        {
            return $"[X] {GetName()} ({GetDescription()}) -- Currently completed: {_amountCompleted}/{_target}";
        }
        else
        {
            return $"[ ] {GetName()} ({GetDescription()}) -- Currently completed: {_amountCompleted}/{_target}";
        }
    }

    public override string GetSaveableString()
    {
        return $"CheckListGoal:{GetName()}|{GetDescription()}|{GetPoints()}|{_bonus}|{_target}|{_amountCompleted}";
    }

    public override int GetBonus()
    {  
        if (_target == _amountCompleted)
        {
            return _bonus;
        }
        return 0;
    }

    public override bool GetComplete()
    {
        return _completed;
    }
}