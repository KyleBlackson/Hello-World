using System;

class Program
{
    static void Main(string[] args)
    {
        static void Welcome ()
        {
        Console.WriteLine("Welcome to the Program");
        }
        static string EnterName (string name1)
        {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
        }
        static int numSquared(int square1)
        {
        Console.Write("Please enter you favorite number: ");
        string blank = Console.ReadLine();
        int favnum = int.Parse(blank);
        int square = favnum*favnum;
        return square;
        }
        static int futureAge(int agePlusOne)
        {
        Console.Write("Please enter your birth year: ");
        string blankOne = Console.ReadLine();
        int birthYear = int.Parse(blankOne);
        int newAge = 2026-birthYear;
        return newAge;
        }
        Welcome();
        static void DisplayMessage()
        {
        string name = EnterName("f");
        int newAge = futureAge(1);
        int square = numSquared(1);
        Console.WriteLine(name+", the square of your number is "+square);
        Console.WriteLine(name+", you will turn "+newAge+" this year");
        }
        DisplayMessage();
        }
}