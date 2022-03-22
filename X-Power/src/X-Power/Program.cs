using Sumomo99.WriteCodeEveryDay;

if (args.Length > 1)
{
    var power = new PowerCaluculate
    {
        Base = int.Parse(args[0]),
        Exponent = int.Parse(args[1])
    };
    Console.WriteLine(power.Caluculate());
}
else
{
    Console.WriteLine("Usage:  dotnet run BASE EXPONENT");
}

namespace Sumomo99.WriteCodeEveryDay
{
    public class PowerCaluculate
    {
        public int Base { get; set; }
        public int Exponent { get; set; }

        public double Caluculate()
        {
            return Math.Pow(Base, Exponent);
        }
    }
}