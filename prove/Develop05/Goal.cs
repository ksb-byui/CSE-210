public abstract class Goal
{
    protected string _name;
    protected int _points;
    protected bool _completed;

    public Goal(string name, int points)
    {
        _name = name;
        _points = points;
        _completed = false;
    }

    public abstract int RecordEvent();
    public abstract string ToDataString();
    public abstract bool IsComplete();
    public abstract string Display();

    public string GetName() => _name;
    public void SetCompleted(bool completed) => _completed = completed;
    public int GetPoints() => _points;
}
