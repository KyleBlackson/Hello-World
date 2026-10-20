using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        ScriptureReference John316 = new ScriptureReference("John", "3", "16");
        Scripture John = new Scripture("For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        John.SplitVerse();

        string UserInput = Console.ReadLine();
        while (UserInput == "")
        {
        {
        Console.Clear();
        John316.DisplayReference();
        John.ChooseRandomWord();
        UserInput = Console.ReadLine();
        }
        }
    }
}