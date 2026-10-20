using System.Text.RegularExpressions;
class Scripture
{
    private string words;

    public Scripture(string _words)
    {
        words = _words;
    }
    public void SplitVerse()
    {
        string[] w  = Regex.Split(words, @"\W+");
        foreach (string p in w)
        {
        Console.Write($"{p} ");
        }
    }

}