using System.Text.RegularExpressions;
class Scripture
{
    private string words;
    ScriptureReference John316 = new ScriptureReference("John", "3", "16");
    private static List<string> verse1 = new List<string>();
    private string [] verse2 = verse1.ToArray();
    public Scripture(string _words)
    {
        words = _words;
    }
    public string[] SplitVerse()
    {
        string [] w  = Regex.Split(words, @"\W+");
        verse1.AddRange(w);
        verse2=verse1.ToArray();

        foreach (string p in w)
        {
        Console.Write($"{p} ");
        Console.WriteLine(verse2);
        }
        return w;
    }


    public void ChooseRandomWord()
    {
        Random rnd = new Random();
        string prompt = verse1[rnd.Next(verse2.Length)];
    }

    





    

}