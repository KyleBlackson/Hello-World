using System.Text.RegularExpressions;
class Scripture
{
    private string words;
    ScriptureReference John316 = new ScriptureReference("John", "3", "16");
    ScriptureReference Proverbs356 = new ScriptureReference("Proverbs", "3", "5", "6");
    private static List<string> verse1 = new List<string>();
    public Scripture(string _words)
    {
        words = _words;
    }

    public string[] SplitVerse()
    {
        verse1.Clear();
        string [] w  = Regex.Split(words, @"\W+");
        verse1.AddRange(w);
        return w;
    }

    public void ClearVerse()
    {
        verse1.Clear();
    }


    public void ChooseRandomWord()
    {
        Random rnd = new Random();
        string prompt = verse1[rnd.Next(verse1.Count)];
        Word myWord = new Word(prompt);
        string tempLook = prompt;
        myWord.Hide();
        string tempHide = myWord.GetWordString();
        int counter = 0;

        while (tempLook == tempHide)
        {
            Random rnd2 = new Random();
            prompt = verse1[rnd2.Next(verse1.Count)];
            Word myWord2 = new Word(prompt);
            tempLook = prompt;
            myWord2.Hide();
            tempHide = myWord2.GetWordString();
            counter++;
            if (counter > 999)
            {
                break;
            }
        }

        for (int i = 0; i < verse1.Count; i++)
        {
        if (verse1[i] == tempLook)
        {
            verse1[i] = tempHide;
        }
        }
        foreach (string q in verse1)
        {
        Console.Write($"{q} ");
        }
        Console.WriteLine("");
    }
}