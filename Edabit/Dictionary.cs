using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Edabit
{
    public class Dictionary
    {
        public static Dictionary<string, int> fruitsDictinary = new Dictionary<string, int>();

        public static void GetPopulated() 
        {
            fruitsDictinary.Add("Apple", 2);
            fruitsDictinary.Add("Pear", 4);
            fruitsDictinary.Add("Orabge", 3);
            fruitsDictinary.Add("Pineapple", 1);
            fruitsDictinary.Add("Peach", 5);
            fruitsDictinary.Add("Banana", 8);
            fruitsDictinary.Add("Mango", 4);
        }
        public static void GetSortedByValue(int num)
        {
            var takePairsNumber = fruitsDictinary.OrderByDescending(pair => pair.Value).Take(num); // sorted by values in descending order (Banana, Peach, Pear, Mango) for number of pair given
            var takePairs = fruitsDictinary.OrderBy(pair => pair.Value).Take(num); // This will return an IEnumerable<KeyValuePair<string, int>> sorted by values in ascending order (Pineapple, Apple, Orabge, Pear) for number of pair given
            // To turn it back into a dictionary, again Linq can help. For example: var top5 = dict.OrderByDescending(pair => pair.Value).Take(5).ToDictionary(pair => pair.Key, pair => pair.Value); 
            foreach (var pair in takePairs)
            {
                Console.WriteLine($"{pair.Key} {pair.Value}");
            }
        }



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
