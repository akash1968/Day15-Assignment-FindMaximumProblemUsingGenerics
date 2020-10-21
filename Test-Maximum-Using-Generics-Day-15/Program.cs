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
            //Refactor 2
            // Refactor  all the 3 to One Generic Class and find the maximum
            FindMaximum<int> maxInt = new FindMaximum<int>(12242, 32323, 21222);
            FindMaximum<double> maxFloat = new FindMaximum<double>(122.43, 323.23, 212.22);
            FindMaximum<string> maxString = new FindMaximum<string>("Alpha","Beta","Gamma");
            Console.WriteLine(maxInt.MaximumMethod());
            Console.WriteLine(maxFloat.MaximumMethod());
            Console.WriteLine(maxString.MaximumMethod());
        }
    }
}
