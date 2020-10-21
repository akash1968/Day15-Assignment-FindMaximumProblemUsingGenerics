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
        // UC 3.1 : Given the maximum string at first position returns the same string.      
        [TestMethod]
        public void GivenMaxStringAtFirstPosition_ReturnTheSameString()
        {
            //Arrange
            string expected = "Gamma";
            //Act
            string actual = FindMaximum.MaxStringAmongThree("Gamma", "Alpha", "Beta");
            //Assert
            Assert.AreEqual(expected, actual);
        }
        // UC 3.2 : Given the maximum string at second position returns the same string.
        [TestMethod]
        public void GivenMaxStringAtSecondPosition_ReturnTheSameString()
        {
            //Arrange
            string expected = "Gamma";
            //Act
            string actual = FindMaximum.MaxStringAmongThree("Alpha", "Gamma","Beta");
            //Assert
            Assert.AreEqual(expected, actual);
        }
        // UC 3.3 : Given the maximum string at third position returns the same string.
        [TestMethod]
        public void GivenMaxStringAtThirdPosition_ReturnTheSameString()
        {
            //Arrange
            string expected = "Gamma";
            //Act
            string actual = FindMaximum.MaxStringAmongThree("Alpha", "Beta", "Gamma");
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
