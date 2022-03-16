using Sumomo99.WriteCodeEveryDay;

if (args.Length > 0)
{
    var mms = new MinMaxSum(args.Select(int.Parse));
    Console.WriteLine($"Min: {mms.Min()}");
    Console.WriteLine($"Max: {mms.Max()}");
    Console.WriteLine($"Sum: {mms.Sum()}");
}
else
{
    Console.WriteLine("コマンドに引数が必要です。");
}

namespace Sumomo99.WriteCodeEveryDay
{
    public class MinMaxSum
    {
        private readonly IEnumerable<int> nums;

        public MinMaxSum(IEnumerable<int> nums)
        {
            this.nums = nums;
        }

        public int Min()
        {
            return nums.Min();
        }

        public int Max()
        {
            return nums.Max();
        }

        public int Sum()
        {
            return nums.Sum();
        }
    }
}