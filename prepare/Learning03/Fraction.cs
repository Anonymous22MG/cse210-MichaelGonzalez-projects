public class Fraction
{
    private int _top;
    private int _bottom;

    // 1) Constructor without parameter-> 1/1
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // 2) Constructor with 1 paramenter: numerator
    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    // 3) Constructor with 2 paramenter: numerator numerador y denominador
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // Getters y setters
    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    // Retun of fraction
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    // Decimal
    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }
}