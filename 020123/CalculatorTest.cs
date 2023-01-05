using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace _020123
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void TestAdd()
        {
            // Arrange
            int x = 2;
            int y = 5;
            // Act
            int result = Adder.Add(x, y);
            // Assert
            Assert.IsTrue(result == 7);
            // Cleanup
        }
    }
}
