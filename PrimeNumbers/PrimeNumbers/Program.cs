using Sumomo99.WriteCodeEveryDay;

if (args.Length > 0)
{
    var prime = new PrimeNumbers() { Number = int.Parse(args[0]) };
    Console.WriteLine(prime.IsPrime());
}
else
{
    Console.WriteLine("Usage:  dotnet run BASE EXPONENT");
}

namespace Sumomo99.WriteCodeEveryDay
{
    public class PrimeNumbers
    {
        public int Number { get; set; }

        public bool IsPrime()
        {
            if (Number == 2)
            {
                return true;
            }

            if (Number < 2 || Number % 2 == 0)
            {
                return false;
            }

            int i = 3;
            while (i <= Math.Sqrt(Number))
            {
                if ( Number % i == 0)
                {
                    return false;
                }
                i += 2;
            }

            return true;
        }
    }
}