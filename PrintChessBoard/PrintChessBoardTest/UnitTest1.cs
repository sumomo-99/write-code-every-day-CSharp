using Xunit;
using Sumomo99.WriteCodeEveryDay;

namespace PrintChessBoardTest;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        PrintChessBoard frame = new (3, 4);
        Assert.Equal("#.#.\n.#.#\n#.#.\n", frame.Print());
    }
}