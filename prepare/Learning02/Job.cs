using System;
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
    public void ShowJob()
    {
        Console.WriteLine($"{_career} ({_workPlace}) {_startYear}-{_endYear}");
    }
}
