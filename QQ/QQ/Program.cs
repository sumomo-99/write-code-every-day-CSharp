using Sumomo99.WriteCodeEveryDay;

var rows = new uint[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

foreach (uint row in rows)
{
    var cols = QQ.CaluculateRow(row);
    int index = 1;
    foreach (uint col in cols)
    {
        Console.WriteLine($"{row} x {index} = {col}");
        index++;
    }
}
namespace Sumomo99.WriteCodeEveryDay
{
    public static class QQ
    {
        public static uint[] CaluculateRow(uint row)
        {
            var cols = new uint[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            return cols.Select(x => row * x)
                        .ToArray();
        }
    }
}