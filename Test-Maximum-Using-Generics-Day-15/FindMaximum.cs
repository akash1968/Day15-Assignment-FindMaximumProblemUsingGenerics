// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FindMaximum.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Akash Kumar Singh"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace Test_Maximum_Using_Generics_Day_15
{
   public class FindMaximum
    {
        // Refactor 1 : Finds the Maximum value among three using generic.
        public static T MaxValueAmongThree<T>(T firstValue, T secondValue, T thirdValue) where T:IComparable
        {
            Console.WriteLine("Maximum Value among {0}, {1} and {2}: ", firstValue, secondValue, thirdValue);
            // Checks if firstValue is great then both secondValue and thirdValue
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0)
                return firstValue;
            // Checks if secondValue is great then both firstValue and thirdValue
            else if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0)
                return secondValue;
            else
                return thirdValue;
        }
    }
}
