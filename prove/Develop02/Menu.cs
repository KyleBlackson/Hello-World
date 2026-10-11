class Menu
{
    
    public int ProcessMenu()
    {

        int input = 0;

        while (input < 1 || input > 5)
        {
            Console.WriteLine("------------MENU-----------");
            Console.WriteLine("1. Create new Journal Entry.");
            Console.WriteLine("2. Display all Journal Entries.");
            Console.WriteLine("3. Load an old Journal File.");
            Console.WriteLine("4. Save current Journal to a file.");
            Console.WriteLine("5. Quit.");
            Console.Write(">");
            input = int.Parse(Console.ReadLine());
        }
        return input;
    }
}
