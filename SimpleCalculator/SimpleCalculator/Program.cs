using Sumomo99.WriteCodeEveryDay;

if (args.Length > 2)
{
    var power = new SimpleCalculator(decimal.Parse(args[0]), char.Parse(args[1]), decimal.Parse(args[2]));
    Console.WriteLine(power.Caluculate());
}
else
{
    Console.WriteLine("コマンドに引数が必要です。");
}

namespace Sumomo99.WriteCodeEveryDay
{
    public class SimpleCalculator
    {
        private readonly decimal x;
        private readonly decimal y;
        private readonly char op;

        public SimpleCalculator(decimal x, char op, decimal y)
        {
            this.x = x;
            this.y = y;
            this.op = op;
        }

        public decimal Caluculate()
        {
            return op switch
            {
              '+' => x + y,
              '-' => x - y,
              '*' => x * y,
              '/' => x / y,
              _ => throw new ArgumentException("計算式に間違いがあります。")
            };
        }
    }
}