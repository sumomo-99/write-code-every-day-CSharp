if (args.Length > 0)
{
    Console.WriteLine(XPower.Power.CalculatePower(int.Parse(args[0]), int.Parse(args[1])));
}
else
{
    Console.WriteLine("コマンドに引数が必要です。");
}

namespace XPower
{
    public static class Power
    {
        public static double CalculatePower(int a, int b)
        {
            return Math.Pow(a, b);
        }
    }
}