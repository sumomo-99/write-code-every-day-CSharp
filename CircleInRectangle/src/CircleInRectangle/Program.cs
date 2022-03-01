if (args.Length > 4)
{
    CircleInRectangle cir = new CircleInRectangle(
      uint.Parse(args[0]),
      uint.Parse(args[1]),
      uint.Parse(args[2]),
      uint.Parse(args[3]),
      uint.Parse(args[4])
    );
    Console.WriteLine(cir.Check());
}
else
{
    Console.WriteLine("コマンドに引数が必要です。");
}

public class CircleInRectangle
{
    uint width;
    uint height;
    uint x;
    uint y;
    uint r;

    public CircleInRectangle(uint width, uint height, uint x, uint y, uint r)
    {
        this.width = width;
        this.height = height;
        this.x = x;
        this.y = y;
        this.r = r;
    }

    public string Check()
    {
        if (x < r ||
            x + r > width ||
            y < r ||
            y + r > height)
        {
            return "No";
        }
        else
        {
            return "Yes";
        }
    }
}