public class EternalGoal : Goal
{
    public EternalGoal(string name, int points) : base(name, points) { }

    public override int RecordEvent()
    {
        return _points;
    }

    public override string ToDataString()
    {
        return $"EternalGoal:{_name},{_points}";
    }

    public override bool IsComplete() => false;

    public override string Display()
    {
        return $"[ ] {_name} - {_points} points (Eternal)";
    }
}
