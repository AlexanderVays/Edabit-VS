using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Edabit
{
    class Strings
    {

        // Compares to string ignore case
        public static bool CompareStr(string first, string second) 
        {
            return first.Equals(second, StringComparison.OrdinalIgnoreCase);
        }

        //count specific characters in a string
        public static int CountVowels(string str)
        {
            int vowelCount = str.Count("aeiouAEIOU".Contains);
            return vowelCount;
        }

        //replace all vowels in the string
        public static string RemoveVowels(string str)
        {
            var charsToRemove = new string[] { "a", "A", "e", "E", "i", "I", "u", "U", "o", "O" };
            for (int i = 0; i < charsToRemove.Length; i++)
            {
                str = str.Replace(charsToRemove[i], "");
            }
            return str;
        }

        //sort characters in a string in an alphabetical order
        public static string AlphabetSoup(string str)
        {
            char[] arr = new char[str.Length];
            arr = str.ToCharArray(0, str.Length);
            Array.Sort(arr);
            return new string(arr);
        }

        //returns counterPart ASCI value (if char is lower, return ASCI of upper case)
        public static int CounterpartCharCode(char symbol)
        {
            char c = symbol;
            if (Char.IsLower(symbol))
            {
                c = Char.ToUpper(c);
            }
            else
            {
                c = Char.ToLower(c);
            }

            return Convert.ToInt32(c);
        }

        //capitalize every first letter of words in the sentence
        public static string MakeTitle(string str)
        {
            StringBuilder sb = new StringBuilder("");
            string[] arrStr = str.Split(' ');
            foreach (string word in arrStr)
            {
                sb.Append($"{Char.ToUpper(word[0])}{word.Substring(1)} ");
            }
            return sb.ToString().Trim();
        }

        //check if palindrome case insensetive and special characters (punctuation or spaces) ignored
        public static bool IsPalindrome(string str)
        {
            string newStr = Regex.Replace(str, "[^a-zA-Z]", "").ToLower();
            int mid = newStr.Length / 2;
            for (int i = 0, j = newStr.Length - 1; i < mid; i++, j--)
            {
                if (newStr[i] != newStr[j])
                {
                    return false;
                }
            }
            return true;
        }

        // function that takes a number as an argument and returns a string formatted to separate thousands.
        public static string FormatNum(int num)
        {
            StringBuilder sb = new StringBuilder();
            string str = num.ToString();
            int counter = 0;
            for (int i = str.Length - 1; i >= 0; i--) 
            {
                sb.Append(str[i]);
                counter++;
                if (counter%3 == 0) 
                {
                    sb.Append(",");
                }
            }
            char[] charArr = sb.ToString().ToCharArray();
            Array.Reverse(charArr);
            return new string(charArr);
        }
    }
}
