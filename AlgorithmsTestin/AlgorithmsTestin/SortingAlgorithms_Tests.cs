using Algorithms.SortingAlgorithms;

namespace AlgorithmsTestin
{
    [TestClass]
    public class SortingAlgorithms_Tests
    {
        [TestMethod]
        public void BubleSort_Test()
        {
            int[] arrayToSort = GetNewArrayToSort();

            BubbleSort.Sort(arrayToSort);
            CollectionAssert.AreEqual(GetNewSortedArray(), arrayToSort);
        }

        [TestMethod]
        public void HeapSort_Test()
        {
            int[] arrayToSort = GetNewArrayToSort();

            HeapSort.Sort(arrayToSort);
            CollectionAssert.AreEqual(GetNewSortedArray(), arrayToSort);
        }

        [TestMethod]
        public void InsertionSort_Test()
        {
            int[] arrayToSort = GetNewArrayToSort();

            InsertionSort.Sort(arrayToSort);
            CollectionAssert.AreEqual(GetNewSortedArray(), arrayToSort);
        }

        [TestMethod]
        public void MergeSort_Test()
        {
            int[] arrayToSort = GetNewArrayToSort();

            MergeSort.Sort(arrayToSort);
            CollectionAssert.AreEqual(GetNewSortedArray(), arrayToSort);
        }

        [TestMethod]
        public void QuickSort_Test()
        {
            int[] arrayToSort = GetNewArrayToSort();

            QuickSort.Sort(arrayToSort);
            CollectionAssert.AreEqual(GetNewSortedArray(), arrayToSort);
        }

        [TestMethod]
        public void SelectionSort_Test()
        {
            int[] arrayToSort = GetNewArrayToSort();

            SelectionSort.Sort(arrayToSort);
            CollectionAssert.AreEqual(GetNewSortedArray(), arrayToSort);
        }

        [TestMethod]
        public void RadixSort_Test()
        {
            int[] arrayToSort = GetNewArrayToSort();
            int[] arrayToSort2 = GetNewArrayToSort2();

            RadixSort.Sort(arrayToSort);
            RadixSort.Sort(arrayToSort2);

            CollectionAssert.AreEqual(GetNewSortedArray(), arrayToSort);
            CollectionAssert.AreEqual(GetNewSortedArray2(), arrayToSort2);
        }


        private int[] GetNewArrayToSort()
        {
            return new int[] { 5, 4, 3, 2, 1, 1, 6, 2, 7, 4 };
        }

        private int[] GetNewArrayToSort2()
        {
            return new int[] { 12, 25, 127, 1, 0, 284, 75, 6 };
        }

        private int[] GetNewSortedArray()
        {
            return new int[] { 1, 1, 2, 2, 3, 4, 4, 5, 6, 7 };
        }

        private int[] GetNewSortedArray2()
        {
            return new int[] { 0, 1, 6, 12, 25, 75, 127, 284 };
        }
    }
}