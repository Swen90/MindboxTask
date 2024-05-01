
namespace MindboxTask.Tests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void Triangle_Square_10_and_12_and_20_Return_45_596()
        {
            //Arrange
            var triangle = new Triangle("Треугольник", 10, 12, 20);
            double expected = 45.596;

            //Act
            var result = triangle.Square();

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void isRightTriangle_ReturnFalse()
        {
            //Arrange
            var triangle = new Triangle("Треугольник", 5, 6, 10);

            // Act
            bool result = triangle.IsRightTriangle();

            //Assert
            Assert.IsFalse(result);
        }
    }
}
