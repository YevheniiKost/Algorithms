using System;
using UnityEngine;

namespace Algorithms
{
    public static class InsertionSort 
    {
        public static void Sort(int[] inputArray)
        {
            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (inputArray[j - 1] > inputArray[j])
                    {
                        int temp = inputArray[j - 1];
                        inputArray[j - 1] = inputArray[j];
                        inputArray[j] = temp;
                    }
                }
            }
        }

        public static void Sort<T>(T[] inputArray) where T : IComparable<T>
        {
            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j++)
                {
                    if (inputArray[j - 1].CompareTo(inputArray[j]) > 0)
                    {
                        var temp = inputArray[j - 1];
                        inputArray[j - 1] = inputArray[j];
                        inputArray[j] = temp;
                    }
                }
            }
        }
    }
}