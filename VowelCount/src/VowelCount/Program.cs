if (args.Length > 0)
{
    Console.WriteLine(VowelCount.Count(args[0]));
}
else
{
    Console.WriteLine("コマンドに引数が必要です。");
}

public static class VowelCount
{
    public static int Count(string str)
    {
      return str.Count(s => "aiueo".Contains(s));
    }
}