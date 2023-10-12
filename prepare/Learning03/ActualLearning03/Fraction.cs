using System.Diagnostics;
using System.Globalization;

public class Fraction
{
private int _numer;

private int _denom;

public Fraction()
{
    _numer = 1;
    _denom = 1;
}

public Fraction(int topNum)
{
    _numer = topNum;
    _denom = 1;
}

public Fraction(int top, int bottom)
{
    _numer = top;
    _denom = bottom;
}

public string GetFractionString()
{
    string text = $"{_numer}/{_denom}";
    return text;
}

public double GetDecimalValue()
{
    return(double)_numer /(double) _denom;
}
}