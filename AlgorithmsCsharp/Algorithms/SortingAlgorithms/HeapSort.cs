namespace Algorithms.SortingAlgorithms
{
    public class HeapSort
    {
        public static void Sort(int[] inputArray)
        {
            int size = inputArray.Length;

            for (int i = size / 2 - 1; i >= 0; i--)
                Heapify(inputArray, size, i);

            for (int i = size - 1; i >= 0; i--)
            {
                int temp = inputArray[0];
                inputArray[0] = inputArray[i];
                inputArray[i] = temp;

                Heapify(inputArray, i, 0);
            }
        }
        
        private static void Heapify(int[] arr, int heapSize, int root)
        {
            int largest = root;
            int left = 2 * root + 1; // left = 2*i + 1
            int right = 2 * root + 2; // right = 2*i + 2

            if (left < heapSize && arr[left] > arr[largest])
                largest = left;

            if (right < heapSize && arr[right] > arr[largest])
                largest = right;

            if (largest != root)
            {
                int swap = arr[root];
                arr[root] = arr[largest];
                arr[largest] = swap;

                Heapify(arr, heapSize, largest);
            }
        }

        public static void Sort<T>(T[] inputArray, int i, int length) where T : IComparable<T>
        {
            int size = length - i + 1;

            for (int j = size / 2 - 1; j >= 0; j--)
                Heapify(inputArray, size, j, i);

            for (int j = size - 1; j >= 0; j--)
            {
                T temp = inputArray[i];
                inputArray[i] = inputArray[i + j];
                inputArray[i + j] = temp;

                Heapify(inputArray, j, 0, i);
            }
        }
        
        private static void Heapify<T>(T[] inputArray, int heapSize, int root, int i) where T : IComparable<T>
        {
            int largest = root;
            int left = 2 * root + 1; // left = 2*i + 1
            int right = 2 * root + 2; // right = 2*i + 2

            if (left < heapSize && inputArray[i + left].CompareTo(inputArray[i + largest]) > 0)
                largest = left;

            if (right < heapSize && inputArray[i + right].CompareTo(inputArray[i + largest]) > 0)
                largest = right;

            if (largest != root)
            {
                T swap = inputArray[i + root];
                inputArray[i + root] = inputArray[i + largest];
                inputArray[i + largest] = swap;

                Heapify(inputArray, heapSize, largest, i);
            }
        }
    }
}
