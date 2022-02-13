if (args.Length > 0)
{
    Console.WriteLine(watch.Seconds.Format(UInt32.Parse(args[0])));
}
else
{
    Console.WriteLine("コマンドに引数が必要です。");
}

namespace watch
{
    public static class Seconds
    {
        public static string Format(uint seconds)
        {
            uint hours = 0;
            uint minutes = 0;

            if (seconds >= 3600)
            {
                hours = seconds / 3600;
                seconds %= 3600;
            }
            if (seconds >= 60)
            {
                minutes = seconds / 60;
                seconds %= 60;
            }
            return $"{hours}:{minutes}:{seconds}";
        }
    }
}