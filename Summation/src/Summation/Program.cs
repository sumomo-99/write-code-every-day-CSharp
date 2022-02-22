if (args.Length > 0)
{
    Console.WriteLine(Summation.Sum(int.Parse(args[0])));
}
else
{
    Console.WriteLine("コマンドに引数が必要です。");
}

public static class Summation
{
    public static int Sum(int num)
    {
        return Enumerable.Range(1, num).Sum();
    }
}