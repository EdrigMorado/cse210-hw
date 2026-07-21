using System;

class Fraction
{
    // Private Attributes
    private int _top;
    private int _bottom;

    // Methods 
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // Getters
    public int GetTop()
    {
        return _top;
    }
    public int GetBottom()
    {
        return _bottom;
    }

    // Setters
    public void SetTop(int top)
    {
        _top = top;
    }
    // Return fraction as string
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    // Return decimal fraction value
    public double Decimal()
    {
        return (double)  _top / _bottom;
    }
}