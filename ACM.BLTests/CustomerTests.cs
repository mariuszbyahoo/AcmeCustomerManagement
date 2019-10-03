using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTests
{
    [TestClass]
    public class CustomerTests
    {
        [TestMethod]
        public void CalculatePercentOfGoalStepsTestValid()
        {
            //-- Arrange
            var customer = new Customer();
            string goalSteps = "5000";
            string actualSteps = "2000";
            decimal expected = 40M;

            //--Act
            var actual = customer.CalculatePercentOfGoalSteps(goalSteps, actualSteps);

            //--Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculatePercentOfGoalStepsTestValidAndSame()
        {
            //-- Arrange
            var customer = new Customer();
            string goalSteps = "5000";
            string actualSteps = "5000";
            decimal expected = 100M;

            //--Act
            var actual = customer.CalculatePercentOfGoalSteps(goalSteps, actualSteps);

            //--Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculatePercentOfGoalStepsTestValidActualIsZero()
        {
            //-- Arrange
            var customer = new Customer();
            string goalSteps = "5000";
            string actualSteps = "0";
            decimal expected = 0M;

            //--Act
            var actual = customer.CalculatePercentOfGoalSteps(goalSteps, actualSteps);

            //--Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
