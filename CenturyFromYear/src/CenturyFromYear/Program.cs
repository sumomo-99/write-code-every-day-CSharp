if (args.Length > 0)
{
    Console.WriteLine(day01.CenturyFromYear.GetCentury(int.Parse(args[0])));
}
else
{
    Console.WriteLine("コマンドに引数が必要です。");
}

namespace day01
{
  public static class CenturyFromYear
  {
      public static int GetCentury(int yeara)
      {
          return 1 + ((yeara - 1) / 100);
      }
  }
}