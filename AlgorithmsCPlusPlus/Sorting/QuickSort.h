
#pragma once

class QuickSort{
    public:
        void sort(int arr[], int size);
    private:
        void quickSort(int arr[], int start, int end);
        void swap(int* a, int* b);
        int partition(int arr[], int start, int end);
};