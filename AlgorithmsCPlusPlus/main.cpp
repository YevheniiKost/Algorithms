#include <iostream>
#include "SortingAlgorithms.h"

void printArray(int arr[], int size){
    for(int i = 0; i < size; i++){
        std::cout << arr[i] << " "<< std::endl;
    }
    std::cout << std::endl;
}

int main(){
    int arr[] = {5, 4, 3, 2, 1};
    int size = sizeof(arr) / sizeof(arr[0]);
    std::cout << "Before sorting: " << std::endl;
    printArray(arr, size);
    insertionSort(arr, size);
    std::cout << "After sorting: " << std::endl;
    printArray(arr, size);
    return 0;
}