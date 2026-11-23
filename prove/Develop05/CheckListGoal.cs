class CheckListGoal : BaseGoal
{
    private int tracker = 0;
    private int completions;
    private int bonus=500;
    private string formattedstring;
    private string ok;
    public CheckListGoal(string name, string description, int points, bool complete, string goalType)
    :base(name,description,points,complete,goalType)
    {
    }
    public CheckListGoal() : base("CheckListGoal")
    {
    }

    public override int RecordEvent()
    {
        int temp=AddPoints();
        tracker +=1 ;
        formattedstring = $"[{ok} --- {tracker}/{completions} ({bonus})";
        if (tracker == completions)
            temp += bonus;
        return temp;
    }

    public string CheckListString()
    {
        ok = base.GetConsoleString();

        Console.WriteLine("How many completions would you like to have?");
        completions = int.Parse(Console.ReadLine());
        Console.WriteLine("How many bonus points will it be worth?");
        bonus = int.Parse(Console.ReadLine());
        formattedstring = $"{ok} --- {tracker}/{completions}";
        return formattedstring;
    }
    public override string GetConsoleString()
    {

        return formattedstring;
    }
}