// Binary search algorithm 
// it required sorted data. This code is written for ascending data.
// But, hint for the descending data is given in comment
using System;
namespace Binary_Search
{
    internal class Program
    {
        // a static method that takes the four arguments and return the int value
        public static int search(int []lists, int low, int high, int searchValue)
        {
            // low must not be greater than high
            if(low <= high)
            {
                // calculate the mid index value
                int midIndex = (low + high) / 2;     // decimal values automatically round up into integer
                if(searchValue == lists[midIndex])
                {
                    return midIndex;
                }
                // search value is higher than the mid index value,
                // we know search value lies on right side of the mid value.
                // So, low value must be update with mid index + 1 
                else if(lists[midIndex] < searchValue)          // Change: lists[midIndex] > searchValue  // for the descending data
                {
                    return search(lists, midIndex+1, high, searchValue);
                }
                // search value is smaller than the mid index value,
                // we know that search value is located left side of the mid value.
                // So, high value must be update with mid index -1 
                else
                {
                    return search(lists, low, midIndex - 1, searchValue);
                }
            }

            // return the -1 while the search value is not found
            return -1;
        }
        static void Main(string[] args)
        {
            // defining the parameters that are requried for search function
            int []numbers = {1,2,3,4,5,6,7,8,9};
            // int []numbers ={9,8,7,6,5,4,3,2,1};

            int high = numbers.Length -1;
            int low = 0;
            int searchValue = 8;

            // calling the search function
            int result =  search (numbers, low, high, searchValue);
            if(result == -1)
            {
                Console.WriteLine("value not found!!!");
            }
            else
            {
                Console.WriteLine($"The search value is: {numbers[result]}, the result found at the index of {result}");

            }
            Console.ReadLine();
        }
    }
}
