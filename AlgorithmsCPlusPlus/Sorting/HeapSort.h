#pragma once

class HeapSort
{

public:
    void sort(int arr[], int size);

private:
    void heapify(int arr[], int size, int i);
    void swap(int* a, int* b);
};
