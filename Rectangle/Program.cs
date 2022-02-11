if (args.Length > 1)
{
    Rectangle rectangle = new(UInt32.Parse(args[0]), UInt32.Parse(args[1]));
    Console.WriteLine("Area: {0}", rectangle.Area());
    Console.WriteLine("Perimeter: {0}", rectangle.Perimeter());
}
else
{
    Console.WriteLine("コマンドに引数が必要です。");
}
readonly struct Rectangle
{
    readonly uint Length;
    readonly uint Breadth;

    internal Rectangle(uint l, uint b)
    {
        Length = l;
        Breadth = b;
    }

    internal uint Area()
    {
        return this.Length * this.Breadth;
    }

    internal uint Perimeter()
    {
        return 2 * (this.Length + this.Breadth);
    }
}