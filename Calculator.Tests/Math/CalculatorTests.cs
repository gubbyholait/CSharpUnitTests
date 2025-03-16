using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Calculator.Tests.Math
{
    [TestClass]
    public class CalculatorTests
    {
        // Naming convention MethodName.Scenario.ExpectedOutcome
        [TestMethod]
        public void Add_AddTwoWholeNumbers_SumofThoseNumbers()
        {
            // Arrange 
            var calculator = new UnitTestCSharp.Math.Calculator();

            //Act
            int res = calculator.Add(45, 55);

            //Assert
            Assert.AreEqual(res, 100);
        }

        [TestMethod]
        public void Add_SubtractTwoWholeNumbers_SumofThoseNumbers()
        {
            // Arrange 
            var calculator = new UnitTestCSharp.Math.Calculator();

            //Act
            int res = calculator.Subtract(55, 45);

            //Assert
            Assert.AreEqual(res, 10);
        }
    }
}
