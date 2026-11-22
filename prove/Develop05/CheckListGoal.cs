class CheckListGoal : BaseGoal
{
    public CheckListGoal(string name, string description, int points, bool complete, string goalType)
    :base(name,description,points,complete,goalType)
    {
    }
    public CheckListGoal() : base("CheckListGoal")
    {
    }

    public override int RecordEvent()
    {
        //check bonus, return points
        return 0;
    }
}