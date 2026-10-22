class Menu
{
    
    public int ProcessMenu()
    {

        int input = 0;

        while (input < 1 || input > 5)
        {
            Console.WriteLine("Welcome to the Scripture Memorizer Program! Select a scripture to start or enter 5 to quit");
            Console.WriteLine("1. John 3:16");
            Console.WriteLine("2. Proverbs 3:5 6");
            Console.WriteLine("3. 1 Corinthians 10:13");
            Console.WriteLine("4. Moroni 10:32 33");
            Console.WriteLine("5. Quit.");
            Console.Write(">");
            input = int.Parse(Console.ReadLine());
        }
        return input;
    }
}
