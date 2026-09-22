using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        List <int> numbers = new List<int>();
        List<string> userInputs = new List<string>();
        int x;
        string xstring;
        Console.WriteLine("Please give me a number to put in the list. Enter 0 when finished.");
        do
        {
        Console.Write("Enter Number: ");
        xstring = Console.ReadLine();
        x = int.Parse(xstring);
        numbers.Add(x);

        }while (x != 0);
        double sum = 0;
        int max = 0;
        int dividing = -1;
        foreach (int number in numbers)
        {
            sum += number;
            dividing += 1;
            if (number>max)
            {
                max = number;
            }

        }
        Console.WriteLine("The sum is: "+sum);
        Console.WriteLine("The average is: "+sum/dividing);
        Console.WriteLine("The highest number in the list is: "+max);

    }
}