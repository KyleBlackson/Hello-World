class Rectangle : Shape
{
    private string _color;
    private double _side;
    private double _height;

    public Rectangle(string color, double side, double height)
    {
        _color = color;
        _side = side;
        _height = height;
    }

    public override string getColor()
    {
        return _color;
    }
    public override double GetArea()
    {
        return _side*_height;
    }
}