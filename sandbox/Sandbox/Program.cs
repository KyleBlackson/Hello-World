using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        int x = 20;

        if (x == 10)
        {
            Console.WriteLine("X is 10");
            Console.WriteLine("Y is fun");
        }
        else if (x == 20)
        {
            Console.WriteLine("X is 20");
        }
        else
        {
            Console.WriteLine("Default output");
        }
    }
}