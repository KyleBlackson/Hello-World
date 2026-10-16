using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;

class Fraction
{
    private int topNumber;
    private int bottomNumber;
    private string fraction;

    public Fraction()
    {
        topNumber = 1;
        bottomNumber = 1;
    }

    public Fraction(int wholeNumber)
    {
        topNumber = wholeNumber;
        bottomNumber = 1;
    }
    public Fraction(int _topNumber, int _bottomNumber)
    {
        fraction = $"{_topNumber}/{_bottomNumber}";
    }

    public int GetTop()
    {
        return topNumber;
    }
    public void SetTop(int _topNumber)
    {
        topNumber = _topNumber;
    }

    public int GetBottom()
    {
        return bottomNumber;
    }

    public void SetBottom(int _bottomNumber)
    {
        bottomNumber = _bottomNumber;
    }

    public string GetFractionString()
    {
         fraction = $"{this.topNumber}/{this.bottomNumber}";
         return fraction;
    }

    public double GetDecimalValue()
    {
        double d_topNumber = topNumber;
        double d_bottomNumber = bottomNumber;
        double _decimal = d_topNumber/d_bottomNumber;
        return _decimal;
    }
}