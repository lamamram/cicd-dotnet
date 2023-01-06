using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace _020123
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod, TestCategory("Unit")]
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

        [TestMethod, TestCategory("Unit")]
        public void TestSum()
        {
            // Arrange
            int[] values = { 1, 2, 3, 4, 5 };
            // Act
            int result = Adder.Sum(values);
            // Assert
            Assert.IsTrue(result == 15);
            // Cleanup
            values = null;
        }
    }
}
