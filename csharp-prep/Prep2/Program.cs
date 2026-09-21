using System;

class Program
{
    static void Main(string[] args)
    {
        int gradeScore;
        string userInput;
        Console.WriteLine("Please Enter Your Grade Score: ");
        userInput = Console.ReadLine ();
        gradeScore = int.Parse(userInput);

        if (gradeScore >= 90)
        {
            Console.WriteLine("You got an A");
        }
        else if (gradeScore >= 80)
        {
            Console.WriteLine("You got a B");
        }
        else if (gradeScore >= 70)
        {
            Console.WriteLine("You got a C");
        }
        else if (gradeScore >= 60)
        {
            Console.WriteLine("You got a D");
        }
        else
        {
            Console.WriteLine("You got an F");
        }
        if (gradeScore >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class");
        }
        else
        {
            Console.WriteLine("You didn't pass the class, but better luck next time!");
        }
    }
}