public class NegativeGoal : Goal
{
    private int _penaltyPoints;

    public NegativeGoal(string name, string description, int penalty)
        : base(name, description, 0)
    {
        _penaltyPoints = penalty;
    }

    public override void RecordEvent()
    {
        // Only Penalty Applies
    }

    public override bool IsComplete() => false;

    public int GetPenalty() => _penaltyPoints;

    public override string GetStringRepresentation()
    {
        return $"NegativeGoal:{_shortName},{_description},{_penaltyPoints}";
    }

    public override string GetDetailsString()
    {
        return $"[!] {_shortName} ({_description}) Penalty: {_penaltyPoints}";
    }
}
