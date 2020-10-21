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
        // Refactor 2: Add Generic Class     
        [TestMethod]
        public void Refactor2_AddedGenericClass()
        {
            //Arrange
            double expected = 1121.22;
            FindMaximum<double> maxFloat = new FindMaximum<double>(1121.22, 1105.32, 1033.23);
            //Act
            double actual = maxFloat.MaximumMethod();
            //Assert
            Assert.AreEqual(expected, actual);
        }
        
    }
}
