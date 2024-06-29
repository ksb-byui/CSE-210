public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _bonusPoints;
    private int _currentCount;

    public ChecklistGoal(string name, int points, int targetCount, int bonusPoints) 
        : base(name, points)
    {
        _targetCount = targetCount;
        _bonusPoints = bonusPoints;
        _currentCount = 0;
    }

    public override int RecordEvent()
    {
        _currentCount++;
        if (_currentCount >= _targetCount)
        {
            _completed = true;
            return _points + _bonusPoints;
        }
        return _points;
    }

    public override string ToDataString()
    {
        return $"ChecklistGoal:{_name},{_points},{_targetCount},{_bonusPoints},{_currentCount},{_completed}";
    }

    public override bool IsComplete() => _completed;

    public override string Display()
    {
        return _completed 
            ? $"[X] {_name} - {_points} points, Completed {_currentCount}/{_targetCount} times, Bonus: {_bonusPoints} points"
            : $"[ ] {_name} - {_points} points, Completed {_currentCount}/{_targetCount} times";
    }
}
