class Circle : Shape
{
    private string _color;
    private double _radius;

    public Circle(string color, double side)
    {
        _color = color;
        _radius = side;
    }

    public override string getColor()
    {
        return _color;
    }
    public override double GetArea()
    {
        return 3.14*_radius*_radius;
    }
}