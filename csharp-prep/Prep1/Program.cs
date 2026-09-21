using System;

class Program
{
    static void Main(string[] args)
    {
        string firstName;
        Console.Write("Please enter your name: ");
        firstName = Console.ReadLine();
        string lastName;
        Console.Write("Please enter your last name: ");
        lastName = Console.ReadLine();

        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}