using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Square q = new Square("red", 14);
        //Console.WriteLine(q.GetArea());
        //Console.WriteLine(q.getColor());

        Rectangle r = new Rectangle("blue", 14, 12.5);
       //Console.WriteLine(r.GetArea());
        //Console.WriteLine(r.getColor());

        Circle s = new Circle("green", 14);
        //Console.WriteLine(s.GetArea());
        //Console.WriteLine(s.getColor());

        List<Shape> myShapes = new List<Shape>();

        myShapes.Add(q);
        myShapes.Add(r);
        myShapes.Add(s);

        foreach (Shape shape in myShapes)
        {
            Console.WriteLine($"The area of the {shape.getColor()} shape is {shape.GetArea()}");
        }
}}