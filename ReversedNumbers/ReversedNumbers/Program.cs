using Sumomo99.WriteCodeEveryDay;

if (args.Length > 0)
{
    var nums = new ReversedNumbers(args.Select(int.Parse).ToArray());
    Console.WriteLine(nums.StrReversedNumbers);
}
else
{
    Console.WriteLine("Usage:  dotnet run [NUMBER] ...");
}

namespace Sumomo99.WriteCodeEveryDay
{
    public class ReversedNumbers
    {
        private readonly int[] _array;

        public string StrReversedNumbers
        {
            get
            {
                var _revArray = _array;
                Array.Reverse(_revArray);

                return string.Join(" ", _revArray);
            }
        }

        public ReversedNumbers(params int[] numbers)
        {
            _array = numbers;
        }
    }
}