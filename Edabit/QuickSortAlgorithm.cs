using System;
using System.Collections.Generic;
using System.Text;

namespace Edabit
{
    class QuickSortAlgorithm
    {
        public static void SortArray(int[] arr) 
        {
            QuickSort(arr, 0, arr.Length - 1);
            foreach (var num in arr)
            {
                Console.WriteLine(num);
            }
        }

        private static void QuickSort(int[] arr, int left, int right)
        {
            int i = left;
            int j = right;
            int pivot = arr[(left + right) / 2];

            while (i <= j) 
            {
                while (arr[i] < pivot) 
                {
                    i++;
                }

                while (arr[j] > pivot) 
                {
                    j--;
                }

                if (i <= j) 
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    i++;
                    j--;
                }
            }

            if (left < j)
            {
                QuickSort(arr, left, j);
            }

            if (i < right)
            {
                QuickSort(arr, i, right);
            }
        }
    }
}
