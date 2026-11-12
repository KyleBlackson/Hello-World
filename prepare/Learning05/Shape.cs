using System.Drawing;

abstract class Shape
{
    private string _color;

    public Shape()
    {
    }
    public abstract string getColor();

    public abstract double GetArea();
}