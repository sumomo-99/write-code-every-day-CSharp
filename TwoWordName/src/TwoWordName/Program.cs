if (args.Length > 0)
{
    Console.WriteLine(TwoWordName.GetInitial(args[0]));
}
else
{
    Console.WriteLine("コマンドに引数が必要です。");
}

public static class TwoWordName
{
    public static string GetInitial(string name)
    {
        IEnumerable<string> ret = name.Split(" ")
          .Select(x => x[0..1].ToUpper());

        return string.Join(".", ret);
    }
}