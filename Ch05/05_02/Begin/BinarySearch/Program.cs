using System;
using static System.Console;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int theValue = 43;
            int[] array =new int[] { 11, 22, 43, 54, 57, 59, 62, 78};
            WriteLine("Our array contains");
            Array.ForEach(array, x => Write(x + " "));

            Write($"\n\nTheresult of a binary search for {theValue} is; ");
            WriteLine(binarySearch(array, theValue));
        }
        /// <summary>
        /// a = array
        /// x = what we're searching
        /// p = first index
        /// q = midpoint
        /// r = last index
        /// </summary>
        public static int binarySearch(int[] a, int x)
        {
            //Step 1 - initialize variables
            int p = 0; //begining of the range
            int r = a.Length - 1; // The end of the range

            //Step 2 = doing something(search for the value)
            while(p <= r) //when true, we are still in the rang
            {
                int q = (p + r) / 2; //find the mid point
                if (x < a[q])
                   r = q - 1;       //set r to mid point. We narroued to 1st
                                    // half of the array in the case x is less
                                    //the data in slot q
                else if (x > a[q])
                    p = q + 1;      //the opposite occurs. WE bring p to the
                                    //right of the array
                                    //here we found our vale b/c x must = q

                else return q;
                
            }

            //Step 3 indicate not found
            return -1;

        }
    }
    
}
