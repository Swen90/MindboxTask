
namespace MindboxTask.Tests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void Circle_Square_10_Return_314_159()
        {
            //Arrange
            var circle = new Circle("Круг", 10);
            double expected = 314.159;

            //Act
            var result = circle.Square();

            //Assert
            Assert.AreEqual(result, expected);
        }
    }
}
