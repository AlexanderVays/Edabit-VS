using System;
using System.Collections.Generic;
using System.Text;

namespace Edabit
{
    class Arrays
    {
        //to print out the array in one line
        //Console.WriteLine("[{0}]", string.Join(", ", yourArray));


        //filter int numbers out of array
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

        //remove the smallest from the array, the array should stay unsorted
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
