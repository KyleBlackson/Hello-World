using System.Text.RegularExpressions;

class Splitter
{
    public Splitter(string verse)
    {
        string[] words  = Regex.Split(verse, @"\W+");
        foreach (string word in words)
        {
        Console.WriteLine(word);
        }
    }
}