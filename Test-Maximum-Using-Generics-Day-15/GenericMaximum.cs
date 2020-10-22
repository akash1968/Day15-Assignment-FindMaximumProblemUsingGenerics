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
        public T Max()
        {
            Array.Sort(this.value);
            //Returns the last element of the array after sorting in ascending order
            return this.value[^1];
        }

    }
}
