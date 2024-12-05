using Lab9;
using Xunit;

namespace Lab9.Tests
{
    public class UnitTests
    {
        [Fact]
        public void TestRectangleArea()
        {
            var rect = new Rectangle(0, 0, 3, 4);
            Assert.Equal(12, rect.Area());
        }

        [Fact]
        public void TestRectangleColor()
        {
            var coloredRect = new RectangleColor(0, 0, 2, 3, "Red");
            Assert.Equal("Red", coloredRect.Color);
        }

        [Fact]
        public void TestAspirantPrint()
        {
            var aspirant = new Aspirant("Doe", 1, "12345");
            aspirant.Print();
            Assert.Equal("Doe", aspirant.LastName);
            Assert.Equal(1, aspirant.Course);
        }

        [Fact]
        public void TestBookGenrePublPrint()
        {
            var book = new BookGenrePubl("C# Programming", "John Doe", 500, "Programming", "TechPub");
            book.Print();
            Assert.Equal("Programming", book.Genre);
            Assert.Equal("TechPub", book.Publisher);
        }
    }
}
