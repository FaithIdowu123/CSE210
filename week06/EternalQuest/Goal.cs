public abstract class Goal
{
    private string _name;
    private string _description;
    private int _points;


    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public int GetPoints()
    {
        return _points;
    }

    public virtual string GetDetails()
    {
        if (iscomplete())
        {
            return $"[X] {_name} ({_description})";
        }
        else
        {
            return $"[ ] {_name} ({_description})";
        }
    }

    public abstract bool iscomplete();

    public abstract string GetSaveableString();

    public abstract void RecordEvent();

    public virtual int GetBonus()
    {
        return 0;
    }

    public virtual bool GetComplete()
    {
        return false;
    }

    public void SetPoints()
    {
        _points = 0;
    }

    public virtual void SetBonus()
    {
        
    }
}