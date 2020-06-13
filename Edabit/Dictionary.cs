using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Edabit
{
    class Dictionary
    {
        //find equal values using a dictionary
        public static int Equal(int a, int b, int c)
        {
            int[] arr = new int[] { a, b, c };
            Dictionary<int, int> myDictionary = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (!myDictionary.ContainsKey(arr[i]))
                {
                    myDictionary.Add(arr[i], 1);
                }
                else
                {
                    myDictionary[arr[i]]++;
                }
            }

            foreach (KeyValuePair<int, int> entry in myDictionary)
            {
                if (entry.Value > 1)
                {
                    return entry.Value;
                }
            }
            return 0;
        }
    }
}
