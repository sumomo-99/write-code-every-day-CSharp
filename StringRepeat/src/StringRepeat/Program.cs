if (args.Length > 0)
{
    Console.WriteLine(StringRepeat.Repeat(args[0], Int32.Parse(args[1])));
}
else
{
    Console.WriteLine("コマンドに引数が必要です。");
}

public static class StringRepeat
{
    public static string Repeat(string originalString, int repeatNumber)
    {
        string returnString = "";

        for (int i = 0; i < repeatNumber; i++)
        {
            returnString += originalString;
        }

        return returnString;

        //https://www.codewars.com/kata/57a0e5c372292dd76d000d7e/solutions/csharp
        //return String.Concat(Enumerable.Repeat(s, n));
    }
}