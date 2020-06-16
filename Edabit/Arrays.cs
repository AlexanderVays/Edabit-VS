using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;

namespace Edabit
{
    class Arrays 
    {
        public static int[] intArr = new int[] { 2, 7, 87, 34, 1, 45, 9 };
        public static string[] fruits = new[] {"Apple", "Pear", "Orange", "Pineapple", "Peach", "Banana", "Mango" };
        //to print out the array in one line
        //Console.WriteLine("[{0}]", string.Join(", ", yourArray));

        // Array.Exists<T>(T[], Predicate<T>) method - Determines whether the specified array contains elements that match the conditions defined by the specified predicate.
        public static void ArrayExists() 
        {
            Console.WriteLine("One or more fruits contains 'a' in their names: {0}",
                Array.Exists(fruits, element => element.Contains("a")));

            Console.WriteLine("One or more fruits begin with 'M': {0}",
                Array.Exists(fruits, element => element.StartsWith("P")));

            Console.WriteLine("One or more planets ends with 'z': {0}",
                Array.Exists(fruits, element => element.EndsWith("T")));

            Console.WriteLine("Is Orange one of the fruits?: {0}",
                Array.Exists(fruits, element => element == "Orange"));
        }

        // Array.Find<T>(T[], Predicate<T>) Method - Searches for an element that matches the conditions defined by the specified predicate, and returns the first occurrence within the entire Array.
        public static object ArrayFind(object[] arr) 
        {
            return Array.Find(fruits, element => element.Contains("a"));
        }

        // Array.FindLast<T>(T[], Predicate<T>) Method - Searches for an element that matches the conditions defined by the specified predicate, and returns the last occurrence within the entire Array.
        public static object ArrayFindLast(object[] arr)
        {
            return Array.FindLast(fruits, element => element.Contains("a"));
        }

        // Array.FindIndex Method - Searches for an element that matches the conditions defined by a specified predicate, and returns the zero-based index of the first occurrence within an Array or a portion of it.
        public static object ArrayFindIndex(object[] arr)
        {
            return Array.FindIndex(fruits, element => element.StartsWith("B"));
        }

        // Array.FindAll<T>(T[], Predicate<T>) Method - Retrieves all the elements that match the conditions defined by the specified predicate. 
        public static object ArrayFindAll(object[] arr)
        {
            var result =  Array.FindAll(fruits, element => element.StartsWith("P")); //return an array of objects whose compy the predicate
            return new string(string.Join(", ", result));
        }

        // Array.Reverse Method - Reverses the order of the elements in a one-dimensional Array or in a portion of the Array.
        public static object ArrayReverse(object[] arr) 
        {
            Array.Reverse(arr);
            return new string(string.Join(", ", arr));
        }

        // Array.Copy Method - Copies a range of elements in one Array to another Array and performs type casting and boxing as required.
        public static object[] ArrayCopy(object[] arr) 
        {
            var newArr = new object[arr.Length];
            Array.Copy(arr, newArr, 3); // third argument indicates number of items to copy, could be aa.Length
            return newArr;
        }

        // Array.Sort Method - Sorting an array in ascending order
        public static object[] ArraySort(object[] arr)
        {
            Array.Sort(arr);
            // Array.Sort(arr, new ReverseComparer());  //reverse sort using ICompare in ReverseComparer class
            return arr;
        }

        // Array.BinarySearch Method - Searches a one-dimensional sorted Array for a value, using a binary search algorithm.
        public static int ArrayBinarySearch(object[] arr, object obj)
        {
            Array.Sort(arr);
            return Array.BinarySearch(arr, obj);  
        }

        // Filters ints (numbers) out of objects array
        public static int[] FilterArray(object[] arr)
        {
            List<int> myList = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].GetType().Equals(typeof(int)))
                {
                    myList.Add(Int32.Parse(arr[i].ToString()));
                }
            }
            return myList.ToArray();
        }

        // Removes the smallest from the array, the array should stay unsorted
        public static int[] RemoveSmallest(int[] values)
        {
            if (values.Length == 0) 
            {
                return values;
            }
            int min = values[0];
            int[] result = new int[values.Length - 1];
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < min) 
                {
                    min = values[i];
                }
            }
            int j = 0;
            for (int i = 0; i < values.Length; i++) 
            {
                if (values[i] != min)
                {
                    result[j] = values[i];
                    j++;
                }
                else 
                {
                    for (int k = i+1, m = j; k < values.Length; k++, m++) 
                    {
                        result[m] = values[k];
                    }
                    break;
                }
            }
            return result;
        }
    }
}
