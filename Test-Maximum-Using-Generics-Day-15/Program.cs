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
            // Refactor all the 3 to One Generic Method and find the maximum
            Console.WriteLine(FindMaximum.MaxValueAmongThree<int>(1222,1231,1021));
            Console.WriteLine(FindMaximum.MaxValueAmongThree<double>(12.22, 12.31, 10.21));
            Console.WriteLine(FindMaximum.MaxValueAmongThree<string>("Alpha", "Beta", "Gamma"));
        }
    }
}
