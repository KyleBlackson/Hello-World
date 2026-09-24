using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Program");
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        Console.Write("Please enter you favorite number: ");
        string blank = Console.ReadLine();
        int favnum = int.Parse(blank);
        Console.Write("Please enter your birth year: ");
        string blankOne = Console.ReadLine();
        int birthYear = int.Parse(blankOne);
        Console.WriteLine(name+", the square of your number is "+favnum*favnum);
        Console.WriteLine(name+", you will turn "+(2026-birthYear)+" this year");
    }
}