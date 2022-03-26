using Sumomo99.WriteCodeEveryDay;

if (args.Length > 1)
{
    var nums = new InsertionSort(args.Select(int.Parse).ToArray());
    Console.WriteLine(String.Join(" ", nums.SortedNumbers));
}
else
{
    Console.WriteLine("Usage:  dotnet run [BASE] [EXPONENT]");
}

namespace Sumomo99.WriteCodeEveryDay
{
    public class InsertionSort
    {
        private readonly int[] _nums;

        public InsertionSort(int[] nums)
        {
            _nums = nums;
        }

        public int[] SortedNumbers {
            get
            {
                var nums = _nums;

                for (int i = 1; i < nums.Length; i++)
                {
                    int value = nums[i];
                    int j = i - 1;

                    while (j >= 0 && nums[j] > value)
                    {
                        nums[j + 1] = nums[j];
                        j--;
                    }

                    nums[j + 1] = value;
                }

                return nums;
            }
        }
    }
}