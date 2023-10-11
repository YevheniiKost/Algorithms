namespace Algorithms.SortingAlgorithms;

public static class QuickSort
{
    public static void Sort(int[] inputArray)
    {
        SortInternal(inputArray, 0, inputArray.Length - 1);
    }

    private static int[] SortInternal(int[] array, int minIndex, int maxIndex)
    {
        if (minIndex >= maxIndex)
        {
            return array;
        }

        var pivotIndex = Partition(array, minIndex, maxIndex);
        SortInternal(array, minIndex, pivotIndex - 1);
        SortInternal(array, pivotIndex + 1, maxIndex);

        return array;
    }

    private static void Swap(ref int x, ref int y)
    {
        var t = x;
        x = y;
        y = t;
    }

    /// <summary>
    /// Divides the array into two subarrays, one with elements smaller than the pivot element, and one with elements
    /// </summary>
    /// <returns>The index of the pivot element.</returns>
    private static int Partition(int[] array, int minIndex, int maxIndex)
    {
        var pivot = minIndex - 1;
        for (var i = minIndex; i < maxIndex; i++)
        {
            if (array[i] < array[maxIndex])
            {
                pivot++;
                Swap(ref array[pivot], ref array[i]);
            }
        }

        pivot++;
        Swap(ref array[pivot], ref array[maxIndex]);
        return pivot;
    }
}