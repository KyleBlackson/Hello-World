using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment myAssignment = new Assignment("Kyle", "Math");
        Console.WriteLine(myAssignment.GetSummary());

        MathAssignment myMathAssignment = new MathAssignment("Jacob", "Algebra", "3.4", "2-11");
        Console.WriteLine(myMathAssignment.GetMathAssignment());

        WritingAssignment myWritingAssignment = new WritingAssignment("Blackson", "English", "The Art of War");
        Console.WriteLine(myWritingAssignment.GetWritingInformation());
    }
}