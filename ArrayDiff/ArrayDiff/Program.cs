using Sumomo99.WriteCodeEveryDay;

if (args.Length > 1)
{
    var diff = new ArrayDiff() { Numbers = args.Select(int.Parse).ToArray() };
    Console.WriteLine(diff.Max());
}
else
{
    Console.WriteLine("Usage:  dotnet run NUMBERS...");
}

namespace Sumomo99.WriteCodeEveryDay
{
    public class ArrayDiff
    {
        public int[] Numbers { get; set; } = {0};

        public int Max()
        {
            List<int> result = new();

            for (int i = 0; i < Numbers.Length - 1; i++)
            {
                result.Add(Numbers[i + 1] - Numbers[i]);
            }

            return result.Max();
        }
    }
}