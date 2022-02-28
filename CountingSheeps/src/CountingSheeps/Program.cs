if (args.Length > 0)
{
    Console.WriteLine(CountingSheeps.Count(args.Select(bool.Parse).ToArray()));
}
else
{
    Console.WriteLine("コマンドに引数が必要です。");
}

public static class CountingSheeps
{
    public static int Count(bool[] sheeps)
    {
        return sheeps.Count(x => x);
    }
}