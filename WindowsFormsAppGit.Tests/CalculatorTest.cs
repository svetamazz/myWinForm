using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WindowsFormsAppGit.Tests
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void addition_5and3_Return8()
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            int result = calculator.addition(5,3);

            // Assert
            Assert.AreEqual(result,8);
        }

        [TestMethod]
        public void subtraction_5and3_Return2()
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            int result = calculator.subtraction(5, 3);

            // Assert
            Assert.AreEqual(result, 2);
        }

        [TestMethod]
        public void multiplication_5and3_Return15()
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            int result = calculator.multiplication(5, 3);

            // Assert
            Assert.AreEqual(result, 15);
        }

        [TestMethod]
        public void division_10and2_Return5()
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            double result = calculator.division(10, 2);


            //Assert.IsTrue(5 == result);
            // Assert
            Assert.AreEqual(result,5);
        }
    }
}
