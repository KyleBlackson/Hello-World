class EternalGoal : BaseGoal
{
    public EternalGoal(string name, string description, int points, bool complete, string goalType)
    :base(name,description,points,complete,goalType)
    {
    }
    public EternalGoal() : base("EternalGoal")
    {
    }

    public override int RecordEvent()
    {
        return AddPoints();
    }

    public override string GetConsoleString()
    {
        return base.GetConsoleString();
    }
}