if (args.Length > 0)
{
    Console.WriteLine(SquareNSum.Sum(args.Select(int.Parse).ToArray()));
}
else
{
    Console.WriteLine("コマンドに引数が必要です。");
}

public static class SquareNSum
{
    public static int Sum(int[] nums)
    {
      return nums
        .Select(x => x * x)
        .Sum();
    }
}