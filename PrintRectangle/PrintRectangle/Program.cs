using Sumomo99.WriteCodeEveryDay;

if (args.Length > 1)
{
    var rectangle = new PrintRectangle(int.Parse(args[0]), int.Parse(args[1]));
    Console.WriteLine(rectangle.Print());
}
else
{
    Console.WriteLine("コマンドに引数が必要です。");
}

namespace Sumomo99.WriteCodeEveryDay
{
    public class PrintRectangle
    {
        private readonly int row;
        private readonly int col;

        public PrintRectangle(int row, int col)
        {
            this.row = row;
            this.col = col;
        }

        public string Print()
        {
            var rectangle = "";

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    rectangle += "#";
                }
                rectangle += "\n";
            }

            return rectangle;
        }
    }
}