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
        Scripture John = new Scripture("For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        John.SplitVerse();

        Console.WriteLine("Welcome to the Scripture Memorizer Program");
        string UserInput = Console.ReadLine();
        while (UserInput == "")
        {
        {
        Console.Clear();
        Console.WriteLine();
        John316.DisplayReference();
        
        John.ChooseRandomWord();
        UserInput = Console.ReadLine();
        }
        }
    }
}