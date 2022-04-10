#include <iostream>

//BUBBLE-SORT(A)
//    for i ← 0 to length(A) – 1
//        do for j ← length(A) - 1 to i + 1
//            do if A[j] < A[j – 1]
//                then swap A[j] ⟷ A[j – 1]

void swap(int *right, int *left) {
    int temp = *left;
    *left = *right;
    *right = temp;
}

void bubbleSort(int arr[], int n) {
    for (int i = 0; i < n - 1; i++)
        for (int j = n - 1; j > i; j--)
            if (arr[j] < arr[j - 1])
                swap(&arr[j], &arr[j - 1]);
}

void printArray(int arr[], int size) {
    for (int i = 0; i < size; i++)
        std::cout << arr[i] << " ";

    std::cout << std::endl;
}

int main() {
    int arr[] = {10, 8, 7, 0, 1};

    int n = sizeof(arr) / sizeof(arr[0]);

    bubbleSort(arr, n);

    std::cout << "\nSorted array: \n";

    printArray(arr, n);

    return 0;
}