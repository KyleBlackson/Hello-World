using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        double gradeScore;
        string userInput;
        Console.WriteLine("Please Enter Your Grade Score: ");
        userInput = Console.ReadLine ();
        gradeScore = double.Parse(userInput);
        string letterGrade;
        string plusOrMinus;
            if (gradeScore >= 90)
            {
            letterGrade = "A";
            }
            else if (gradeScore >= 80)
            {
            letterGrade = "B";
            }
            else if (gradeScore >= 70)
            {
            letterGrade = "C";
            }
            else if (gradeScore >= 60)
            {
            letterGrade = "D";
            }
            else
            {
            letterGrade = "F";
            }
            if (gradeScore >= 70)
            {
            Console.WriteLine("Congratulations! You passed the class");
            }
            else
            {
            Console.WriteLine("You didn't pass the class, but better luck next time!");
            }
        if (gradeScore >= 97)
        {
            Console.WriteLine(letterGrade);
        }

        else if (gradeScore <= 63)
        {
            Console.WriteLine(letterGrade);

        }
        else
        {
        {
        gradeScore = gradeScore%10;
        if (gradeScore >=7)
        {
            plusOrMinus = "+";
        }
        else if (gradeScore <= 3)
        {
            plusOrMinus = "-";
        }
        else
        {
            plusOrMinus = "";
        }
        Console.WriteLine(letterGrade+plusOrMinus);
        }
        }
    }
}