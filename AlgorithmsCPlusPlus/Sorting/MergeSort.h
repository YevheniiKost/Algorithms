#pragma once

class MergeSort
{
public:
    void sort(int arr[], int size);

private:
    void merge(int arr[], int start, int mid, int end);
    void mergeSort(int arr[], int start, int end);
};