if (args.Length > 1)
{
    Console.WriteLine(CalculateBMI.Calculate(double.Parse(args[0]), double.Parse(args[1])));
}
else
{
    Console.WriteLine("コマンドに引数が必要です。");
}

public static class CalculateBMI
{
    public static string Calculate(double weight, double height)
    {
        double bmi = weight / Math.Pow(height, 2);

        string ret = bmi switch
        {
            <= 18.5 => "Underweight",
            <= 25.0 => "Normal",
            <= 30.0 => "Overweight",
            _ => "Obese",
        };

        return ret;
    }
}