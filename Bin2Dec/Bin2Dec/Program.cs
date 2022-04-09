using Sumomo99.WrteCodeEveryDay;

Console.WriteLine(Bin2Dec.Calculate(args[0]));

namespace Sumomo99.WrteCodeEveryDay
{
    public static class Bin2Dec
    {
        public static int Calculate(string str)
        {
            foreach (var c in str)
            {
                if (c != '0' && c != '1')
                {
                    throw new ArgumentException("Input '0' or '1'");
                }
            }

            return Convert.ToInt32(str, 2);
        }
    }
}