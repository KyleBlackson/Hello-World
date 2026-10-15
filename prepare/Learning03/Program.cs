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

        Console.WriteLine(p3.GetFractionString(""));

    }
}