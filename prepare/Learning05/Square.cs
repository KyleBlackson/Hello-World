using System.Drawing;

class Square : Shape
{
    private string _color;
    private double _side;

    public Square(string color, double side)
    {
        _color = color;
        _side = side;
    }

    public override string getColor()
    {
        return _color;
    }
    public override double GetArea()
    {
        return _side*_side;
    }
}