using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Menu myMenu = new Menu();

        int response = 0;
        while(response != 5)
        {
            response = myMenu.ProcessMenu();
            switch(response)
            {
                case 1:
                    Console.Clear();
                    ScriptureReference John316 = new ScriptureReference("John", "3", "16");
                    Scripture John = new Scripture("For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
                    John316.DisplayReference();
                    Console.WriteLine("For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
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
                    Console.Clear();
                    John.ClearVerse();
                    break;
                case 2:
                    Console.Clear();
                    ScriptureReference Proverbs356 = new ScriptureReference("Proverbs", "3", "5", "6");
                    Scripture Proverbs = new Scripture("Trust in the Lord with all thine heart and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");
                    Proverbs356.DisplayReference();
                    Console.WriteLine("Trust in the Lord with all thine heart and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");
                    Proverbs.SplitVerse();
                    string UserInput2 = Console.ReadLine();
                    while (UserInput2 == "")
                    {
                    {
                    Console.Clear();
                    Proverbs356.DisplayReference();
                    Proverbs.ChooseRandomWord();
                    UserInput2 = Console.ReadLine();
                    }
                    }
                    Console.Clear();
                    Proverbs.ClearVerse();
                    break;
                case 3:                
                    Console.Clear();
                    ScriptureReference Corinthians1013 = new ScriptureReference("Corinthians", "10", "13");
                    Scripture Corinthians = new Scripture("There hath no temptation taken you but such as is common to man: but God is faithful, who will not suffer you to be tempted above that ye are able; but will with the temptation also make a way to escape, that ye may be able to bear it.");
                    Corinthians1013.DisplayReference();
                    Console.WriteLine("There hath no temptation taken you but such as is common to man: but God is faithful, who will not suffer you to be tempted above that ye are able; but will with the temptation also make a way to escape, that ye may be able to bear it.");
                    Corinthians.SplitVerse();
                    string UserInput3 = Console.ReadLine();
                    while (UserInput3 == "")
                    {
                    {
                    Console.Clear();
                    Corinthians1013.DisplayReference();
                    Corinthians.ChooseRandomWord();
                    UserInput3 = Console.ReadLine();
                    }
                    }
                    Console.Clear();
                    Corinthians.ClearVerse();
                    break;
                case 4:               
                    Console.Clear();
                    ScriptureReference Moroni1032 = new ScriptureReference("Moroni", "10", "32", "33");
                    Scripture Moroni = new Scripture("Yea, come unto Christ, and be perfected in him, and deny yourselves of all ungodliness; and if ye shall deny yourselves of all ungodliness, and love God with all your might, mind and strength, then is his grace sufficient for you, that by his grace ye may be perfect in Christ; and if by the grace of God ye are perfect in Christ, ye can in nowise deny the power of God.And again, if ye by the grace of God are perfect in Christ, and deny not his power, then are ye sanctified in Christ by the grace of God, through the shedding of the blood of Christ, which is in the covenant of the Father unto the remission of your sins, that ye become holy, without spot.");

                    Moroni1032.DisplayReference();
                    Console.WriteLine("Yea, come unto Christ, and be perfected in him, and deny yourselves of all ungodliness; and if ye shall deny yourselves of all ungodliness, and love God with all your might, mind and strength, then is his grace sufficient for you, that by his grace ye may be perfect in Christ; and if by the grace of God ye are perfect in Christ, ye can in nowise deny the power of God.And again, if ye by the grace of God are perfect in Christ, and deny not his power, then are ye sanctified in Christ by the grace of God, through the shedding of the blood of Christ, which is in the covenant of the Father unto the remission of your sins, that ye become holy, without spot.");
                    Moroni.SplitVerse();
                    string UserInput4 = Console.ReadLine();
                    while (UserInput4 == "")
                    {
                    {
                    Console.Clear();
                    Moroni1032.DisplayReference();
                    Moroni.ChooseRandomWord();
                    UserInput4 = Console.ReadLine();
                    }
                    }
                    Console.Clear();
                    Moroni.ClearVerse();
                    break;
            }
        }
    }
}