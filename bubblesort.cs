//BUBBLE - SORT(A)
//  for i ← 0 to length(A) – 1
//	do for j ← length(A) - 1 to i + 1
//		do if A[j] < A[j – 1]
//			then swap A[j] ⟷ A[j – 1]

using System;

class SortBubble
{

    static void Swap(ref int right, ref int left)
    {
        int temp = left;
        left = right;
        right = temp;
    }

    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;

        for (int i = 0; i < n - 1; i++)
            for (int j = n - 1; j > i; j--)
                if (arr[j] < arr[j - 1])
                    Swap(ref arr[j], ref arr[j - 1]);
    }

    static void PrintArray(int[] arr)
    {
        int n = arr.Length;

        for (int i = 0; i < n; i++)
            Console.Write(arr[i] + " ");

        Console.WriteLine();
    }

    public static void Main()
    {
        int[] arr = { 10, 8, 7, 0, 1 };

        BubbleSort(arr);

        Console.WriteLine("Sorted array");

        PrintArray(arr);
    }
}