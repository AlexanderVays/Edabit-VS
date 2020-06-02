using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Edabit
{
    class Mathematic
    {
        //Check if the number is prime number
        public static bool IsPrime(int value)
        {
            if (value > 0)
            {
                if (value != 1 && value % 2 != 0 && value % 3 != 0 && value % 5 != 0 && value % 7 != 0
                     || value == 2 || value == 3 || value == 5 || value == 7)
                {
                    return true;
                }
                return false;
            }
            return false;
        }

        //Greater Common Divider
        public static int GCD(int a, int b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                {
                    a %= b;
                }
                else
                {
                    b %= a;
                }
            }
            return a == 0 ? b : a;
        }

        //sorting number in descending order SortDescending(2619805) ➞ 9865210
        public static int SortDescending(int num)
        {
            string str = num.ToString();
            Console.WriteLine("before sorting " + str);
            char[] char_arr = str.ToCharArray();
            Array.Sort(char_arr);
            Array.Reverse(char_arr);
            string result = new string(char_arr);
            Console.WriteLine("after sorting" + result);
            return Int32.Parse(result);
        }

        //finding Fibonachi number recursively
        public static int GetFib(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }

            return GetFib(n - 1) + GetFib(n - 2);
        }

        //finding Fibonachi 
        public static int GetFibonachi(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }

            int[] nums = new int[n + 1];
            nums[0] = 1; nums[1] = 1;
            for (int i = 2; i <= n; i++)
            {
                nums[i] = nums[i - 1] + nums[i - 2];
            }
            return nums[n];
        }

        // returns the number of ways to climb number of steps with provided an array
        // where n indicates the number of steps, and arr indicates the array which consists of number of steps can be taken at once
        public static int GetWays(int n, int[] arr)
        {
            int total = 0;
            if (n == 0)
            {
                return 1;
            }
            foreach (int i in arr)
            {
                if (n - i >= 0)
                {
                    total += GetWays(n - i, arr);
                }
            }
            return total;
        }

        //Create a function that takes in n, a, b and returns the number of values raised to the nth power that lie in the range [a, b], inclusive.
        public static int PowerRanger(int power, int min, int max)
        {
            int count = 0;
            for (int i = min; i <= max; i++)
            {
                double temp = Math.Pow(i, (double)1 / power);
                if (temp-Convert.ToInt32(temp)==0)
                {
                    count++;
                }
            }
            return count;

        }
    }
}
