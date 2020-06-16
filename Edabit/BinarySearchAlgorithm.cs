using System;
using System.Collections.Generic;
using System.Text;

namespace Edabit
{
    //BinarySearch searches for an item index of the arrray
    // In order to binary search an array it has to be sorted. In order to sort "Array.Sort()" method can be used
    // For example if the array consist of 2000000 it will loop maximum 21 times
    class BinarySearchAlgorithm
    {
        public static int BinarySearch(int[] arr, int num) 
        {
            Array.Sort(arr);
            int left = 0;
            int right = arr.Length - 1;
            while (left <= right) 
            {
                int middle = (left + right) / 2;
                if (num == arr[middle])
                {
                    return middle;
                }

                if (num < arr[middle])
                {
                    right = middle - 1;
                }
                else
                {
                    left = middle + 1;
                }
            }

            return -1;
        }
        
    }
}
