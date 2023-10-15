namespace Algorithms.SortingAlgorithms;

public static class RadixSort
{
    public static void Sort(int[] inputArray)
    {
        var max = GetMax(inputArray);
        for (var exp = 1; max / exp > 0; exp *= 10)
        {
            CountSort(inputArray, exp);
        }
    }

    private static void CountSort(int[] inputArray, int exp)
    {
        int size = inputArray.Length;
        var outputArray = new int[size];
        var countArray = new int[10];
        
        for (var i = 0; i < size; i++)
        {
            countArray[(inputArray[i] / exp) % 10]++;
        }
        
        for (var i = 1; i < 10; i++)
        {
            countArray[i] += countArray[i - 1];
        }
        
        for (var i = size - 1; i >= 0; i--)
        {
            outputArray[countArray[(inputArray[i] / exp) % 10] - 1] = inputArray[i];
            countArray[(inputArray[i] / exp) % 10]--;
        }
        
        for (var i = 0; i < size; i++)
        {
            inputArray[i] = outputArray[i];
        }
    }

    private static int GetMax(int[] inputArray)
    {
        var max = inputArray[0];
        for (var i = 1; i < inputArray.Length; i++)
        {
            if (inputArray[i] > max)
            {
                max = inputArray[i];
            }
        }

        return max;
    }
}