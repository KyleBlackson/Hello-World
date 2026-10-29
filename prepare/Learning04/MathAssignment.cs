using System.Security.Cryptography;

class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string studentName, string topic, string textbooksection, string problems)
    : base(studentName, topic)
    {
        _textbookSection = textbooksection;
        _problems = problems;
    }

    public string GetMathAssignment()
    {
        Console.WriteLine(GetSummary());
        return $"Section: {_textbookSection}  Problems {_problems}";
    }
}