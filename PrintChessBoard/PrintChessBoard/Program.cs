using Sumomo99.WriteCodeEveryDay;

if (args.Length > 1)
{
    var frame = new PrintChessBoard(int.Parse(args[0]), int.Parse(args[1]));
    Console.WriteLine(frame.Print());
}
else
{
    Console.WriteLine("コマンドに引数が必要です。");
}

namespace Sumomo99.WriteCodeEveryDay
{
    public class PrintChessBoard
    {
        private readonly int row;
        private readonly int col;

        public PrintChessBoard(int row, int col)
        {
            this.row = row;
            this.col = col;
        }

        public string Print()
        {
            var frame = "";

            for (int h = 0; h < row; h++)
            {
                for (int w = 0; w < col; w++)
                {
                    if (h % 2 == 0)
                    {
                        if (w % 2 == 0)
                        {
                          frame += "#";
                        }
                        else
                        {
                          frame += ".";
                        }
                    }
                    else
                        if (w % 2 == 0)
                        {
                          frame += ".";
                        }
                        else
                        {
                          frame += "#";
                        }
                    {
                    }
                }
                frame += "\n";
            }

            return frame;
        }
    }
}