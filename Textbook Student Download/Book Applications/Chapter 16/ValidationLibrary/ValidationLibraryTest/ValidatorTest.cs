using Microsoft.VisualStudio.TestTools.UnitTesting;
using Murach.Validation;

namespace ValidationLibraryTest
{
    [TestClass]
    public class ValidatorTest
    {
        [TestMethod]
        public void IsDecimal_ValidValue()
        {            
            string expected = "";                              // arrange
            var result = Validator.IsDecimal("3.14", "Name");  // act
            Assert.AreEqual(expected, result);                 // assert
        }

        [TestMethod]
        public void IsDecimal_InvalidValue()
        {
            string name = "Test field";                        // arrange
            var result = Validator.IsDecimal("three", name);   // act
            Assert.IsTrue(result.Contains(name));              // assert
        }
    }
}
