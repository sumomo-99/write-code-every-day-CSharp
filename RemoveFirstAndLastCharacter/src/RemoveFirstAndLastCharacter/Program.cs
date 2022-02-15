if (args.Length > 0)
{
    Console.WriteLine(RemoveChar.Remove(args[0]));
}
else
{
    Console.WriteLine("コマンドに引数が必要です。");
}

public static class RemoveChar
{
    public static string Remove(string inputString)
    {
        char[] chars =
          inputString
            .ToCharArray(1, inputString.Length - 2);

        return new String(chars);
    }
}