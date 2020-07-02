using System;
using System.Collections.Generic;
using System.Text;

namespace Edabit
{
    class StackQueue
    {
        public static int Fish(int[] A, int[] B)
        {
            Stack<int> fishStack = new Stack<int>();
            int eatenFishes = 0; // represent eaten number of fishes
            for (int i = 0; i < A.Length; i++)
            { // loop through the all fishes
                if (fishStack.Count > 0 && B[i] == 0)
                { // if in stuck flowing downstream fishes and the fish on a specific index i is flowing downstream
                    if (fishStack.Peek() > A[i])
                    { // if the top fish is bigger than a fish on index i
                        eatenFishes++; // increments counter of eaten fishes 
                    }
                    else
                    {
                        while (fishStack.Count > 0 && fishStack.Peek() < A[i])
                        { //loop till the stack is empty or fish in the stack eats the flowing downstream fish
                            fishStack.Pop(); // top fish in stack removed
                            eatenFishes++; // fish in stack been eaten 
                        }
                        if (fishStack.Count > 0)
                        {
                            eatenFishes++; // flowing downstream fish been eaten
                        }
                    }
                }
                else if (B[i] == 1)
                {
                    fishStack.Push(A[i]);
                }
            }
            return (A.Length - eatenFishes);
        }

        // check if the parentheses in the string are correctly placed
        public static bool CheckParentheses(string str) 
        {
            Dictionary<char, char> myDict = new Dictionary<char, char>();
            myDict.Add(')', '(');
            myDict.Add(']', '[');
            myDict.Add('}', '{');
            Stack<char> myStack = new Stack<char>();
            foreach (char c in str) 
            {
                if (c == '(' || c == '[' || c == '{' || c == ')' || c == ']' || c == '}') 
                {
                    if (myDict.ContainsKey(c))
                    {
                        if (myStack.Count == 0)
                        {
                            return false;
                        }

                        if (myStack.Pop() != myDict[c])
                        {
                            return false;
                        }
                    }
                    else 
                    {
                        myStack.Push(c);
                    }
                }
            }

            if (myStack.Count > 0) 
            {
                return false;
            }
            return true;
        }
    }
}
