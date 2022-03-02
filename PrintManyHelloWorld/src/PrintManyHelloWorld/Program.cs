if (args.Length > 0)
{
    Console.WriteLine(HelloWorld.Print(int.Parse(args[0])));
}
else
{
    Console.WriteLine("コマンドに引数が必要です。");
}

public static class HelloWorld
{
    public static string Print(int num)
    {
        int n = 0;
        string ret = "";
        while (n < num)
        {
            ret += "Hello World\n";
            n++;
        }
        return ret;
    }
}