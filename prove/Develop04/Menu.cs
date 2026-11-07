class Menu
{
    public int ProcessMenu()
    {

        int input = 0;

        while (input < 1 || input > 5)
        {
            Console.WriteLine("Welcome to the Mindfulness Program!");
            Console.WriteLine("1. Learn about the Benefits of Mindfulness!");
            Console.WriteLine("2. Breathing Activity");
            Console.WriteLine("3. Reflection Activity");
            Console.WriteLine("4. Listing Activity");
            Console.WriteLine("5. Quit.");
            Console.Write(">");
            input = int.Parse(Console.ReadLine());
        }
        return input;
    }
}
