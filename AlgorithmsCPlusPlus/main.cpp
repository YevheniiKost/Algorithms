#include <iostream>
#include "Sorting/SortingAlgorithms.h"
#include "Sorting/QuickSort.h"
#include "Sorting/MergeSort.h"
#include "Sorting/HeapSort.h"
#include "Sorting/RadixSort.h"

void printArray(int arr[], int size){
    for(int i = 0; i < size; i++){
        std::cout << arr[i] << " " << std::endl;
    }
    std::cout << std::endl;
}

int main(){
    int arr[] = {5, 4, 3, 2, 1, 6, 8, 0, 12};
    int size = sizeof(arr) / sizeof(arr[0]);
    std::cout << "Before sorting: " << std::endl;
    printArray(arr, size);
    RadixSort* radixSort = new RadixSort(); 
    radixSort->sort(arr, size);
    std::cout << "After sorting: " << std::endl;
    printArray(arr, size);
    return 0;
}