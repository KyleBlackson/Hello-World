using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new ();
        int magicNumber;
        magicNumber = randomGenerator.Next(1,11);
        string guessString;
        int guess;
        
        do
        {
        Console.WriteLine("Please guess a number between 1-10");
        guessString = Console.ReadLine();
        guess = int.Parse(guessString);

        if (guess == magicNumber)
            Console.WriteLine("Congratulations! You guessed the number correctly");

        else if (guess > magicNumber)
        {
            Console.WriteLine("Lower");
        }
        else if (guess < magicNumber)
        {
            Console.WriteLine("Higher");
        }
        }
        while (guess != magicNumber);
    }
}