namespace Algorithms.SortingAlgorithms;

public class BubbleSort
{
    public static void Sort(int[] inputArray)
    {
        int length = inputArray.Length;
        for (int i = 0; i < length -1; i++)
        {
            for (int j = 0; j < length- i - 1; j++)
            {
                if(inputArray[j] > inputArray[j + 1])
                {
                    int temp = inputArray[j];
                    inputArray[j] = inputArray[j + 1];
                    inputArray[j + 1] = temp;
                }
            }
        }
    }

    public static void Sort<T>(T[] inputArray) where T : IComparable<T>
    {
        int length = inputArray.Length;
        for (int i = 0; i < length -1; i++)
        {
            for (int j = 0; j < length- i - 1; j++)
            {
                if(inputArray[j].CompareTo(inputArray[j + 1]) > 0)
                {
                    T temp = inputArray[j];
                    inputArray[j] = inputArray[j + 1];
                    inputArray[j + 1] = temp;
                }
            }
        }
    }
}