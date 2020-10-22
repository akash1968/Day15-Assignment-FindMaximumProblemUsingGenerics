using System;
using System.Collections.Generic;
using System.Text;

namespace Test_Maximum_Using_Generics_Day_15
{
    //UC:4- Extend the Maximum method to take more then three parameters
    public class GenericMaximum<T> where T : IComparable
    {
        //creating a generic array
        public T[] value;
        //creating a parametrized constructor which take generic array as parameter
        public GenericMaximum(T[] value)
        {
            this.value = value;
        }
        //creating a find maximum method which sort the array and returns the maximum value
        public void Max()
        {
            // sorting array in ascending order
            Array.Sort(this.value);
            PrintMax();
        }
        //Creating a Print maximum method to print the maximum value in the array
        public void PrintMax()
        {
            //Returns the last element of the array 
            Console.WriteLine("The maximum value among is " + this.value[^1]);
        }
    }
}
