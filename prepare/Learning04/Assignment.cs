class Assignment
{
    protected string _studentname;
    private string _topic;

    public Assignment(string studentName, string topic)
    {
        _studentname = studentName;
        _topic = topic;
    }

    public string GetSummary()
    {
        return $"{_studentname} - {_topic}";
    }

}