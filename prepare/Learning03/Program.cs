using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction p1 = new Fraction();
        p1.SetTop(0);
        Console.WriteLine(p1.GetTop());

        Fraction p2 = new Fraction(3);
        p2.SetTop(4);
        Console.WriteLine(p2.GetTop());

        Fraction p3 = new Fraction(3,4);
        p3.SetTop(6);
        p3.SetBottom(7);

        Console.WriteLine(p3.GetFractionString());
        Console.WriteLine(p3.GetDecimalValue());
        
        Fraction f = new Fraction();
    
        for (int i = 0; i <25; i++)
        {
        Random rnd = new Random();
        int topNumber = rnd.Next(0,100);
        int bottomNumber = rnd.Next(0,100);
        f.SetTop(topNumber);
        f.SetBottom(bottomNumber);
        Console.WriteLine($"Fraction 1: string:{f.GetFractionString()} Number:{f.GetDecimalValue()}");
        }
    

    }
}