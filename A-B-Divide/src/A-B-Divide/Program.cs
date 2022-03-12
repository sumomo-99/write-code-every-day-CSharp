if (args.Length > 1)
{
    (int, int, decimal) tup = day01.AB_Divide.Divide(int.Parse(args[0]), int.Parse(args[1]));
    Console.WriteLine($"a / b (整数) : {tup.Item1}");
    Console.WriteLine($"a / b (あまり) : {tup.Item2}");
    Console.WriteLine($"a / b (小数) : {tup.Item3}");
}
else
{
    Console.WriteLine("コマンドに引数が必要です。");
}

namespace day01
{
    public static class AB_Divide
    {
        public static (int, int, decimal) Divide(int a, int b)
        {
            return (a / b, a % b, (decimal)a / (decimal)b);
        }
    }
}