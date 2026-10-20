using System.Text.RegularExpressions;
class Scripture
{
    private string words;
    ScriptureReference John316 = new ScriptureReference("John", "3", "16");
    private static List<string> verse1 = new List<string>();
    public Scripture(string _words)
    {
        words = _words;
    }
    public string[] SplitVerse()
    {
        string [] w  = Regex.Split(words, @"\W+");
        verse1.AddRange(w);

        foreach (string p in w)
        {
        Console.Write($"{p} ");
        }
        return w;
    }


    public void ChooseRandomWord()
    {
        Random rnd = new Random();
        string prompt = verse1[rnd.Next(verse1.Count)];
        Word myWord = new Word(prompt);
        string tempLook = prompt;
        myWord.Hide();
        string tempHide = prompt;

        for (int i = 0; i < verse1.Count; i++)
        {
        if (verse1[i] == tempLook)
        {
            verse1[i] = tempHide;
        }
        }
        foreach (string q in verse1)
        {
        Console.Write(q);
        }
    }

    





    

}