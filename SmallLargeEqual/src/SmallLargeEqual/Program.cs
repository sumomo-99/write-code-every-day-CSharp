if (args.Length > 1)
{
    Console.WriteLine(SmallLargeEqual.CompareNumbers(int.Parse(args[0]), int.Parse(args[1])));
}
else
{
    Console.WriteLine("コマンドに引数が必要です。");
}

public static class SmallLargeEqual
{
    public static string CompareNumbers(int a, int b)
    {
        string op = (a - b) switch
        {
            var x when x < 0 => "<",
            var x when x > 0 => ">",
            var x when x == 0 => "=",
            _ => ""
        };

        return $"{a} {op} {b}";
    }
}