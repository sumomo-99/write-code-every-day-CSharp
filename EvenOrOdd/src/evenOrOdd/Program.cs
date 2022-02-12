if (args.Length > 0)
{
    Console.WriteLine(checkEven(Int32.Parse(args[0])));
}
else
{
    Console.WriteLine("コマンドに引数が必要です。");
}

static string checkEven(int number)
{
  return (number % 2) switch
  {
    0 => "Even",
    _ => "Odd",
  };
}