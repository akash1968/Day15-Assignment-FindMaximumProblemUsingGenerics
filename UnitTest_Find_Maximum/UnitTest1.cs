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
        // UC 2.1 : Given the maximum float at first position returns the same number.      
        [TestMethod]
        public void GivenMaxFloatAtFirstPosition_ReturnTheSameFloat()
        {
            //Arrange
            double expected = 12.21;
            //Act
            double actual = FindMaximum.MaxFloatAmongThree(12.21, 12.01, 12.19);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        // UC 2.2 : Given the maximum float at second position returns the same float.
       [TestMethod]
        public void GivenMaxFloatAtSecondPosition_ReturnTheSameFloat()
        {
            //Arrange
            double expected = 12.21;
            //Act
            double actual = FindMaximum.MaxFloatAmongThree(12.01, 12.21, 12.19);
            //Assert
            Assert.AreEqual(expected, actual);
        }
      // UC 2.3 : Given the maximum float at third position returns the same float.
        [TestMethod]
        public void GivenMaxFloatAtThirdPosition_ReturnTheSameFloat()
        {
            //Arrange
            double expected = 12.21;
            //Act
            double actual = FindMaximum.MaxFloatAmongThree(12.01, 12.19, 12.21);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
