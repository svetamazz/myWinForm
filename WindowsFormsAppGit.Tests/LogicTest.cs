using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsAppGit;

namespace WindowsFormsAppGit.Tests
{
    [TestClass]
    public class LogicTest
    {
        [TestMethod]
        public void checkUserAge_UserAge10_ReturnFalse()
        {
            // Arrange
            Logic logic = new Logic();
            User user = new User { Age = 10 };

            // Act
            bool result=logic.checkUserAge(user);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void checkUserAge_UserAge20_ReturnTrue()
        {
            // Arrange
            Logic logic = new Logic();
            User user = new User { Age = 20 };

            // Act
            bool result = logic.checkUserAge(user);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void checkNumber_NumberEven_ReturnTrue()
        {
            // Arrange
            Logic logic = new Logic();

            // Act
            logic.checkNumber(2);

            // Assert
            Assert.IsTrue(true);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void checkNumber_NumberOdd_ThrowException()
        {
            // Arrange
            Logic logic = new Logic();

            // Act
            logic.checkNumber(1);

            // Assert
        }
    }
}
