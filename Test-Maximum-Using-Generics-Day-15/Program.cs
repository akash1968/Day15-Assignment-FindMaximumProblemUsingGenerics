// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Akash Kumar Singh"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
namespace Test_Maximum_Using_Generics_Day_15
{
    class Program
    {
        static void Main(string[] args)
        {
            //UC:5- Extend the max method and Print Using Generic Method
            
            // Find the maximum among int parameters in the int array
            int[] intArray = { 1211, 2323, 4343, 5434, 8787, 5436, 7656 };
            GenericMaximum<int> genericInteger = new GenericMaximum<int>(intArray);
            //Printing by calling the generic Max Method
            genericInteger.Max();
            
            // Find the maximum among int parameters in the int array
            double[] doubleArray = { 122.34, 211.32, 433.23, 432.11, 544.23, 232.11 };
            GenericMaximum<double> genericDouble = new GenericMaximum<double>(doubleArray);
            //Printing by calling the generic Max Method
            genericDouble.Max();
           
            // Find the maximum among int parameters in the int array
            string[] stringArray = { "Alpha", "Beta", "Gamma", "Zeta" };
            GenericMaximum<string> genericString = new GenericMaximum<string>(stringArray);
            //Printing by calling the generic Max Method
            genericString.Max();
        }
    }
}
