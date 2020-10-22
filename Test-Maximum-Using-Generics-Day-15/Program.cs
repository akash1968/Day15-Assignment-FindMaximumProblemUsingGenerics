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
            //UC:4- Extend the Maximum method to take more then three parameters
            
            // Find the maximum among int parameters in the int array
            int[] intArray = { 1211, 2323, 4343, 5434, 8787, 5436, 7656 };
            GenericMaximum<int> genericInt = new GenericMaximum<int>(intArray);
            Console.WriteLine("The maximum integer is " + genericInt.Max());
            
            // Find the maximum among int parameters in the int array
            double[] doubleArray = { 122.34, 211.32, 433.23, 432.11, 544.23, 232.11 };
            GenericMaximum<double> genericDouble = new GenericMaximum<double>(doubleArray);
            Console.WriteLine("The maximum Float is " + genericDouble.Max());
           
            // Find the maximum among int parameters in the int array
            string[] stringArray = { "Alpha", "Beta", "Gamma", "Zeta" };
            GenericMaximum<string> genericString = new GenericMaximum<string>(stringArray);
            Console.WriteLine("The maximum String is " + genericString.Max());
        }
    }
}
