using Sumomo99.WriteCodeEveryDay;

if (args.Length > 0)
{
    var power = new PowerCaluculate(int.Parse(args[0]), int.Parse(args[1]));
    Console.WriteLine(power.Caluculate());
}
else
{
    Console.WriteLine("コマンドに引数が必要です。");
}

namespace Sumomo99.WriteCodeEveryDay
{
    public class PowerCaluculate
    {
        private readonly int b; //base
        private readonly int exponent;

        public PowerCaluculate(int b, int exponent)
        {
            this.b = b;
            this.exponent = exponent;
        }

        public double Caluculate()
        {
            return Math.Pow(b, exponent);
        }
    }
}