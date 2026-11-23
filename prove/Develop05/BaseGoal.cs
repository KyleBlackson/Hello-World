using System.Dynamic;

public abstract class BaseGoal
{
    private string _name;
    private string _description;
    private int _points;
    private bool _complete;
    private string _goalType;

    public BaseGoal(string name, string description, int points, bool complete, string goalType)
    {
        _name = name;
        _description = description;
        _points = points;
        _complete = complete;
        _goalType = goalType;
    }
    public BaseGoal(string goalType)
    {
        SetName();
        SetDescription();
        SetPoints();
        _complete = false;
        _goalType=goalType;
    }

    private void SetName()
    {
        Console.Write("What is the name of your goal: ");
        _name = Console.ReadLine();
    }

    private void SetDescription()
    {
        Console.Write($"What is the description of {_name} goal: ");
        _description = Console.ReadLine();
    }

    private void SetPoints()
    {
        Console.Write($"What are the points for {_name} goal: ");
        _points = int.Parse(Console.ReadLine());
    }


    public virtual string GetConsoleString()
    {
        string completeString = " ";
        if (_complete)
            completeString = "X";
        return $"[{completeString}] {_name}, ({_description})";
    }
    public virtual string FileOutputString()
    {
        string completeString = "False";
        if (_complete)
            completeString = "True";
        return $"{completeString}|{_goalType}|{_name}|{_description}|{_points}";
    }

    public int MarkComplete()
    {
        _complete = true;
        return _points;
    }

    public int AddPoints()
    {
        return _points;
    }
    public string CreateFileSystemString()
    {
        return FileOutputString();
    }

    public string GetName()
    {
        return _name;
    }
    public abstract int RecordEvent();
}