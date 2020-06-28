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
    }
}
