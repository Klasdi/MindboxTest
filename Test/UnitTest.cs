using MindboxTest;

namespace Test
{
    public class UnitTest1
    {
        [Fact]
        public void TestCircle1()
        {
            var circle = new Circle(10);
            Assert.Equal(314.15926535897931, circle.Square());
        }
        [Fact]
        public void TestCircle2()
        {
            Assert.Throws<Exception>(() => new Circle(-1));
        }

        [Fact]
        public void TestTriangle1()
        {
            var triangle = new Triangle(10, 10, 10);
            Assert.Equal(43.301270189221931, triangle.Square());
        }
        [Fact]
        public void TestTriangle2()
        {
            Assert.Throws<Exception>(() => new Triangle(-1, 9, 9));
        }
        [Fact]
        public void TestTriangle3()
        {
            var triangle = new Triangle(3, 5, 4);
            Assert.True(triangle.IsRightTriangle());
        }
    }
}