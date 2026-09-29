public class Job
{
    public string _workPlace = "";
    public string _career = "";
    public int _startYear = 0;
    public int _endYear = 0;

    public Job()
    {
        _workPlace = "";
        _career = "";
        _startYear = 0;
        _endYear = 0;
    }

    public void AddJob()
    {
        Console.WriteLine("Where did you work?");
        _workPlace = Console.ReadLine();
        Console.WriteLine("What did you do?");
        _career = Console.ReadLine();
        Console.WriteLine("What year did you start?");
        _startYear = int.Parse(Console.ReadLine());
        Console.WriteLine("What year did you end?");
        _endYear = int.Parse(Console.ReadLine());
    }
    public void ShowJob()
    {
        Console.WriteLine(_workPlace);
        Console.WriteLine(_career);
        Console.WriteLine(_startYear);
        Console.WriteLine(_endYear);
    }
}