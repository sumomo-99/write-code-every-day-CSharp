if (args.Length > 0)
{
    Console.WriteLine($"{SumOfPositive.Sum(args)}");
}
else
{
    Console.WriteLine("コマンドに引数が必要です。");
}

public static class SumOfPositive
{
    public static int Sum(string[] args)
    {
        int ret = args
                  .Select(int.Parse)
                  .Where(num => num > 0)
                  .Sum();

        return ret;
    }
}