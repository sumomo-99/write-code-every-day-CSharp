if (args.Length > 2)
{
    Console.WriteLine(day01.HowManyDivisors.Count(int.Parse(args[0]), int.Parse(args[1]), int.Parse(args[2])));
}
else
{
    Console.WriteLine("コマンドに引数が必要です。");
}

namespace day01
{
    public static class HowManyDivisors
    {
        public static int Count(int start, int end, int number)
        {
            var count = 0;

            for (var i = start; i <= end; i++)
            {
                count += (number % i) switch
                {
                    0 => 1,
                    _ => 0
                };
            }

            return count;
        }
    }
}