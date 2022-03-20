using Sumomo99.WriteCodeEveryDay;

if (args.Length > 1)
{
    var frame = new PrintFrame(int.Parse(args[0]), int.Parse(args[1]));
    Console.WriteLine(frame.Print());
}
else
{
    Console.WriteLine("コマンドに引数が必要です。");
}

namespace Sumomo99.WriteCodeEveryDay
{
    public class PrintFrame
    {
        private readonly int row;
        private readonly int col;

        public PrintFrame(int row, int col)
        {
            this.row = row;
            this.col = col;
        }

        public string Print()
        {
            var frame = "";

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (i == 0 || i == row - 1 || j == 0 || j == col - 1)
                    {
                        frame += "#";
                    }
                    else
                    {
                        frame += ".";
                    }
                }
                frame += "\n";
            }

            return frame;
        }
    }
}