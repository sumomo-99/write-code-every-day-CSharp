if (args.Length > 0)
{
    Console.WriteLine(
      String.Join(" ", SrotingNumbers.Sort(args.Select(int.Parse).ToArray())
      )
    );
}
else
{
    Console.WriteLine("コマンドに引数が必要です。");
}

public static class SrotingNumbers
{
    public static int[] Sort(int[] nums)
    {
      Array.Sort(nums);
      return nums;
    }
}