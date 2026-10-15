using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
class Program
{
    static void Main(string[] args)
    {
        Circle myCircle = new Circle();

        //myCircle.SetRadius(10);

        double area = myCircle.GetArea();

        Console.WriteLine(area);
    }
}


/*
class Practice
{
    static void Main(int[] list)
    {
        List<int> lownumber = new List<int>();
        int x = 5;
        lownumber.Add(x);
        lownumber.Add(83);
        lownumber.Add(99);

        foreach (item in  lownumber)
        {
            if (string item > lownumber.[0])
            {
                x = item;
            }
        }
        Console.WriteLine(x);
    }
    
}
*/