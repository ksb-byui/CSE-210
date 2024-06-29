public class SimpleGoal : Goal
{
    public SimpleGoal(string name, int points) : base(name, points) { }

    public override int RecordEvent()
    {
        _completed = true;
        return _points;
    }

    public override string ToDataString()
    {
        return $"SimpleGoal:{_name},{_points},{_completed}";
    }

    public override bool IsComplete() => _completed;

    public override string Display()
    {
        return _completed ? $"[X] {_name} - {_points} points" : $"[ ] {_name} - {_points} points";
    }
}
