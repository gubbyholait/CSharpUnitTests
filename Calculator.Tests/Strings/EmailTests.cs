using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Tests.Strings
{
    [TestClass]
    public class EmailTests
    {
        // Naming convention MethodName.Scenario.ExpectedOutcome
        [TestMethod]
        public void IsValid_ValidEmailAddress_ReturnTrue()
        {
            // Arrange 
            var emailValidator = new UnitTestCSharp.Strings.EmailValidaotr();

            //Act
            bool res = emailValidator.IsValidEmail("gholait@hotmail.co.uk");

            //Assert
            Assert.IsTrue(res);
        }

        [TestMethod]
        public void IsValid_EmptyEmail_ReturnFalse()
        {
            // Arrange 
            var emailValidator = new UnitTestCSharp.Strings.EmailValidaotr();

            //Act
            bool res = emailValidator.IsValidEmail("");

            //Assert
            Assert.IsFalse(res);
        }

        [TestMethod]
        public void IsValid_EmailWithNoAtSign_ReturnFalse()
        {
            // Arrange 
            var emailValidator = new UnitTestCSharp.Strings.EmailValidaotr();

            //Act
            bool res = emailValidator.IsValidEmail("gubbyholait.com");

            //Assert
            Assert.IsFalse(res);
        }

        [TestMethod]
        public void IsValid_EmailWithNoPeriod_ReturnFalse()
        {
            // Arrange 
            var emailValidator = new UnitTestCSharp.Strings.EmailValidaotr();

            //Act
            bool res = emailValidator.IsValidEmail("gubbyholait@com");

            //Assert
            Assert.IsFalse(res);
        }
    }
}
