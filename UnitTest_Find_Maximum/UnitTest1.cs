// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UnitTest1.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Akash Kumar Singh"/>
// --------------------------------------------------------------------------------------------------------------------
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test_Maximum_Using_Generics_Day_15;

namespace UnitTest_Find_Maximum
{
    [TestClass]
    public class UnitTest1
    {
        // UC 1.1 : Given the maximum number at first position returns the same number.      
        [TestMethod]
        public void GivenMaxNumberAtFirstPosition_ReturnTheSameNumber()
        {
            //Arrange
            int expected = 200;
            //Act
            int actual = FindMaximum.MaxIntegerAmongThree(200, 10, 100);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        // UC 1.2 : Given the maximum number at second position returns the same number.
       [TestMethod]
        public void GivenMaxNumberAtSecondPosition_ReturnTheSameNumber()
        {
            //Arrange
            int expected = 1200;
            //Act
            int actual = FindMaximum.MaxIntegerAmongThree(1122, 1200, 1109);
            //Assert
            Assert.AreEqual(expected, actual);
        }
      // UC 1.3 : Given the maximum number at third position returns the same number.
        [TestMethod]
        public void GivenMaxNumberAtThirdPosition_ReturnTheSameNumber()
        {
            //Arrange
            int expected = 2322;
            //Act
            int actual = FindMaximum.MaxIntegerAmongThree(1232, 1221, 2322);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
