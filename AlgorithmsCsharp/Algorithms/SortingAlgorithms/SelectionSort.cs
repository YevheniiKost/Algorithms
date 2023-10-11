namespace Algorithms.SortingAlgorithms
{
    public static class SelectionSort
    {
        public static int[] Sort(int[] inputArray)
        {
            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < inputArray.Length; j++)
                {
                    if (inputArray[j] < inputArray[min])
                    {
                        min = j;
                    }
                }
                
                var temp = inputArray[i];
                inputArray[i] = inputArray[min];
                inputArray[min] = temp;
            }
            
            return inputArray;
        }
        
        public static void Sort<T>(T[] inputArray) where T : IComparable<T>
        {
            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < inputArray.Length; j++)
                {
                    if (inputArray[j].CompareTo(inputArray[min]) < 0)
                    {
                        min = j;
                    }
                }
                
                var temp = inputArray[i];
                inputArray[i] = inputArray[min];
                inputArray[min] = temp;
            }
        }
    }
}