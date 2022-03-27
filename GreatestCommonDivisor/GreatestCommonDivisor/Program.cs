using Sumomo99.WriteCodeEveryDay;

if (args.Length > 1)
{
    var gcd = new GreatestCommonDivisor(int.Parse(args[0]), int.Parse(args[1]));
    Console.WriteLine(gcd.GCD);
}
else
{
    Console.WriteLine("Usage:  dotnet run X Y");
}

namespace Sumomo99.WriteCodeEveryDay
{
    public class GreatestCommonDivisor
    {
        private int x;
        private int y;

        public int GCD
        {
            get
            {
                if ( x < y)
                {
                    (x, y) = (y, x);
                }

                while(y > 0)
                {
                    var r = x % y;
                    x = y;
                    y = r;
                }

                return x;
            }
        }

        public GreatestCommonDivisor(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}