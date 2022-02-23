if (args.Length > 0)
{
    Console.WriteLine(Smallest.GetSmallest(args.Select(int.Parse).ToArray()));
}
else
{
    Console.WriteLine("コマンドに引数が必要です。");
}

public static class Smallest
{
    public static int GetSmallest(int[] numbers)
    {
      return numbers.Min();
    }
}