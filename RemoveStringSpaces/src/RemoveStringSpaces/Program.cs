if (args.Length > 0)
{
    Console.WriteLine(RemoveStringSpaces.Remove(args[0]));
}
else
{
    Console.WriteLine("コマンドに引数が必要です。");
}

public static class RemoveStringSpaces
{
    public static string Remove(string str)
    {
      return str.Replace(" ", "");
    }
}