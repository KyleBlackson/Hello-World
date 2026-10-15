using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;

class Fraction
{
    private int topNumber;
    private int bottomNumber;
    private string fraction;
    private double _decimal;

    public Fraction()
    {
        topNumber = 1/1;
    }
    public Fraction(int wholeNumber)
    {
        topNumber = wholeNumber/1;
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
        _topNumber = topNumber;
    }

    public int GetBottom()
    {
        return bottomNumber;
    }

    public void SetBottom(int _bottomNumber)
    {
        _bottomNumber = bottomNumber;
    }

    public string GetFractionString(string fraction)
    {
         fraction = $"{SetTop}/{SetBottom}";
         return fraction;
    }

    public void GetDecimalValue(double _decimal)
    {
       // _decimal = SetTop/SetBottom;
    }
}