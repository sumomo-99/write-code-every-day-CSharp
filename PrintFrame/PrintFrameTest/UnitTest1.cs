using Xunit;
using Sumomo99.WriteCodeEveryDay;

namespace PrintFrameTest;

public class UnitTest1
{
    [Fact]
    public void Frame_2_3()
    {
        PrintFrame frame = new PrintFrame(3, 4);
        Assert.Equal("####\n#..#\n####\n", frame.Print());
    }
}