class Menu
{
    public int ProcessMenu()
    {

        int input = 0;

        while (input < 1 || input > 6)
        {
            Console.WriteLine("Welcome to the Goal Setting Program!");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit.");
            Console.Write(">");
            input = int.Parse(Console.ReadLine());
        }
        return input;
    }
    public int ProcessSubMenu()
    {

        int input = 0;

        while (input < 1 || input > 3)
        {
            Console.WriteLine("The types of Goals are:");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            Console.Write("What type of Goal would you like to create? ");
            input = int.Parse(Console.ReadLine());
        }
        return input;
    }
}
