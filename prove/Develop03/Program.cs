using System;

class Program
{
    static void Main(string[] args)
    {
        Word myWord = new Word("Secret");
        myWord.Display();
        myWord.Hide();
        myWord.Display();

        ScriptureReference John316 = new ScriptureReference("John", "3", "16");
        John316.DisplayReference();
    }
}