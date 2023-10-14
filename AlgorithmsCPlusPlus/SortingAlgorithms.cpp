
void bubbleSort(int arr[], int size){
    for(int i = 0; i < size; i++){
        for(int j = 0; j < size - 1; j++){
            if(arr[j] > arr[j + 1]){
                int temp = arr[j + 1];
                arr[j + 1] = arr[j];
                arr[j] = temp;
            }
        } 
    }
}

void insertionSort(int arr[], int size){
    int i, key, j;
    for(i = 1; i < size; i++){
        key = arr[i];
        j = i - 1;

        while(j >= 0 && arr[j] > key){
            arr[j + 1] = arr[j];
            j = j - 1; 
        }
        arr[j + 1] = key;
    }
}

void selectionSort(int arr[], int size){
    int i, j, min_idx;
    for(i = 0; i < size - 1; i++){
        min_idx = i;
        for(j = i + 1; j < size; j++){
            if(arr[j] < arr[min_idx]){
                min_idx = j;
            }
        }
        int temp = arr[min_idx];
        arr[min_idx] = arr[i];
        arr[i] = temp;
    }
}