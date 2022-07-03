namespace Sumomo99.WriteCodeEveryDay;

public static class Power
{
    public static double Caluculate(int base1, int exponent)
    {
        return Pow(base1, exponent);
    }

    public static double Caluculate(string base1, string exponent)
    {
        return Pow(Int32.Parse(base1), Int32.Parse(exponent));
    }

    static double Pow(int base1, int exponent)
    {
        return Math.Pow(base1, exponent);
    }
}
