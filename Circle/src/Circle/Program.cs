using Sumomo99.WriteCodeEveryDay;

if (args.Length > 0)
{
    var circle = new Circle(float.Parse(args[0]));
    Console.WriteLine($"面積: {circle.Area()}");
    Console.WriteLine($"円周: {circle.Circumferencerea()}");
}
else
{
    Console.WriteLine("コマンドに引数が必要です。");
}

namespace Sumomo99.WriteCodeEveryDay
{
    public class Circle
    {
        const float PI = 3.141592653589f;
        private readonly float radius;

        public Circle(float radius)
        {
            this.radius = radius;
        }

        public float Area()
        {
            return radius * radius * PI;
        }

        public float Circumferencerea()
        {
            return 2 * radius * PI;
        }
    }
}