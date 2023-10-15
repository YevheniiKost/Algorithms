#include <iostream>
#include "QuickSort.h"


void QuickSort::sort(int arr[], int size)
{
    quickSort(arr, 0, size - 1);
}

int QuickSort::partition(int array[], int low, int high)
{   
  int pivot = array[high];
  
  int i = (low - 1);

  for (int j = low; j < high; j++) {
    if (array[j] <= pivot) {
        
      i++;
      
      swap(&array[i], &array[j]);
    }
  }
  
  swap(&array[i + 1], &array[high]);
  
  return (i + 1);
}
 
 void QuickSort::quickSort(int arr[], int start, int end)
{  
    if(start < end)
    {   
        int partitionIndex = partition(arr, start, end);
        quickSort(arr, start, partitionIndex - 1); 
        quickSort(arr, partitionIndex + 1, end); 
    }
}

void QuickSort::swap(int* a, int* b)
{
    int temp = *a;
    *a = *b;
    *b = temp;
}