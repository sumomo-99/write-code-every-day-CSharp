using System;

if (args.Length > 0)
{
    Console.WriteLine(XPower.Power.CalculatePower(args[0], args[1]));
}
else
{
    Console.WriteLine("コマンドに引数が必要です。");
}

namespace XPower
{
    public static class Power
    {
        public static double CalculatePower(string a, string b)
        {
            return Math.Pow(Double.Parse(a), Double.Parse(b));
        }
    }
}