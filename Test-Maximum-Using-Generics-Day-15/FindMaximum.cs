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
   public class FindMaximum<T> where T: IComparable
    {
        //Initialising  generic values
        T firstValue, secondValue, thirdValue;
         //Creating Parameterized constructor which take generic values
        public FindMaximum(T firstValue, T secondValue, T thirdValue)
        {
            this.firstValue = firstValue;
            this.secondValue = secondValue;
            this.thirdValue = thirdValue;
        }
        // Refactor 2 : Finds the Maximum value among three using generic.
        private static T MaximumValueAmongThree(T firstValue, T secondValue, T thirdValue)
        {
            Console.WriteLine("Maximum value among {0}, {1} and {2}: ", firstValue, secondValue, thirdValue);
            /// Checks if firstValue is great then both secondValue and thirdValue
            if (firstValue.CompareTo(secondValue) >= 0 && firstValue.CompareTo(thirdValue) >= 0)
                return firstValue;
            /// Checks if secondValue is great then both firstValue and thirdValue
            else if (secondValue.CompareTo(firstValue) >= 0 && secondValue.CompareTo(thirdValue) >= 0)
                return secondValue;
            else
                return thirdValue;
        }
        //TestMaximum method to internally call the static test maximum method passing the 3 instance variables
        public T MaximumMethod()
        {
            T maxValue = MaximumValueAmongThree(this.firstValue, this.secondValue, this.thirdValue);
            return maxValue;
        }
    }
}
