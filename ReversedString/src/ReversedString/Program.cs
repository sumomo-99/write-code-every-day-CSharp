if (args.Length > 0)
{
    Console.WriteLine(ReversedString.Reverse(args[0]));
}
else
{
    Console.WriteLine("コマンドに引数が必要です。");
}

public static class ReversedString {
  public static string Reverse(string str) {
    string ret = "";

    for (int i = str.Length -1; i >= 0; i--) {
      ret += str[i];
    }

    return ret;
  }
}