using System.Collections.Concurrent;
using System.Security.Cryptography.X509Certificates;

class ScriptureReference
{
    private string _book;
    public string _chapter;
    public string _verse;
    public string _startVerse;
    public string _endVerse;
    public ScriptureReference(string book, string chapter, string verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public ScriptureReference(string book, string chapter, string startVerse, string endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    public void DisplayReference()
    {
        Console.WriteLine($"{_book} {_chapter}:{_verse}{_startVerse} {_endVerse}");
    }
}