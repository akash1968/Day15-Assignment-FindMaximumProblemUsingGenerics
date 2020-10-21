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
        // Refactor 1: Add Generic Method     
        [TestMethod]
        public void Refactor1_AddedGenericMethod()
        {
            //Arrange
            string expected = "Gamma";
            //Act
            string actual = FindMaximum.MaxValueAmongThree<string>("Gamma", "Alpha", "Beta");
            //Assert
            Assert.AreEqual(expected, actual);
        }
        
    }
}
