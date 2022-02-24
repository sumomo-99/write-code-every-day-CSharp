if (args.Length > 2)
{
    Console.WriteLine(Range.CheckRange(args.Select(int.Parse).ToArray()));
}
else
{
    Console.WriteLine("コマンドに引数が必要です。");
}

public static class Range
{
    public static string CheckRange(int[] numbers)
    {
      if (numbers[0] < numbers[1] && numbers[1] < numbers[2]) {
        return "Yes";
      } else {
        return "No";
      }
    }
}