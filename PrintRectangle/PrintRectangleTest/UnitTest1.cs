using Xunit;
using Sumomo99.WriteCodeEveryDay;

namespace PrintRectangleTest
{
    public class UnitTest1
    {
        [Fact]
        public void Rectangle_2_3()
        {
            PrintRectangle rectangle = new PrintRectangle(2, 3);
            Assert.Equal("###\n###\n", rectangle.Print());
        }
    }
}