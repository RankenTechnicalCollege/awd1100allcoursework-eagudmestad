using Microsoft.VisualStudio.TestTools.UnitTesting;
using Murach.Validation;

namespace ValidationLibTest
{
    [TestClass]
    public class ValidatorTest
    {
        [TestMethod]
        public void IsWithinRange_Valid()
        {
            // Arrange
            string value = "9";
            string name = "Price";
            decimal min = 0.0m;
            decimal max = 100.0m;

            // Act
            var result = Validator.IsWithinRange(value, name, min, max);

            // Assert
            Assert.AreEqual("", result);
        }

        [TestMethod]
        public void IsWithinRange_InvalidTooSmall()
        {
            // Arrange
            string value = "-9";
            string name = "Price";
            decimal min = 0.0m;
            decimal max = 100.0m;
            string expectedResult = name + " must be between " + min + " and " + max + ".\n";

            // Act
            var result = Validator.IsWithinRange(value, name, min, max);

            // Assert
            Assert.IsTrue(result == expectedResult);
        }

        [TestMethod]
        public void IsWithinRange_InvalidTooLarge()
        {
            // Arrange
            string value = "101";
            string name = "Price";
            decimal min = 0.0m;
            decimal max = 100.0m;
            string expectedResult = name + " must be between " + min + " and " + max + ".\n";

            // Act
            var result = Validator.IsWithinRange(value, name, min, max);

            // Assert
            Assert.IsTrue(result == expectedResult);
        }
    }
}