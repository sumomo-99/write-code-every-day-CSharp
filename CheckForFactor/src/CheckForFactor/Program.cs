if (args.Length > 1)
{
    Console.WriteLine(day01.CheckForFactor.Check(int.Parse(args[0]), int.Parse(args[1])));
}
else
{
    Console.WriteLine("コマンドに引数が必要です。");
}

namespace day01
{
  public static class CheckForFactor
  {
      public static bool Check(int b, int factor)
      {
          return b % factor == 0;
      }
  }
}