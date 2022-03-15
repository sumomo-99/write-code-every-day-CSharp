using Sumomo99.WriteCodeEveryDay;

if (args.Length > 1)
{
    var power = new PowerCaluculate(int.Parse(args[0]), int.Parse(args[1]));
    Console.WriteLine(power.Caluculate());
}
else
{
    Console.WriteLine("Usage:  dotnet run [BASE] [EXPONENT]");
}

namespace Sumomo99.WriteCodeEveryDay
{
    public class PowerCaluculate
    {
        private readonly int _base;
        private readonly int _exponent;

        public PowerCaluculate(int @base, int exponent)
        {
            _base = @base;
            _exponent = exponent;
        }

        public double Caluculate()
        {
            return Math.Pow(_base, _exponent);
        }
    }
}