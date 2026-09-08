# Advanced Sorting: Bubble Sort & Selection Sort

## Overview
Basic comparison-based sorting algorithms useful for learning and small input sizes. Manual implementations shown in C#.

---

## Bubble Sort
Bubble sort repeatedly steps through the list, compares adjacent elements and swaps them if they are in the wrong order. Optimizations include stopping early if no swaps occur in a pass.

### Example
Array: [5, 1, 4, 2, 8]
- After passes it becomes sorted to [1,2,4,5,8]

### C# Implementation (optimized)
```csharp
public void BubbleSort(int[] arr)
{
    int n = arr.Length;
    for (int i = 0; i < n - 1; i++)
    {
        bool swapped = false;
        for (int j = 0; j < n - 1 - i; j++)
        {
            if (arr[j] > arr[j + 1])
            {
                int tmp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = tmp;
                swapped = true;
            }
        }
        if (!swapped) break; // array already sorted
    }
}
```

Time: O(n^2) worst/average, O(n) best (already sorted with early stop). Space: O(1). Stable: Yes.

---

## Selection Sort
Selection sort selects the smallest (or largest) element from the unsorted portion and swaps it with the first unsorted element.

### Example
Array: [64, 25, 12, 22, 11]
- After selecting minima sequentially -> [11,12,22,25,64]

### C# Implementation
```csharp
public void SelectionSort(int[] arr)
{
    int n = arr.Length;
    for (int i = 0; i < n - 1; i++)
    {
        int minIndex = i;
        for (int j = i + 1; j < n; j++)
        {
            if (arr[j] < arr[minIndex])
                minIndex = j;
        }
        if (minIndex != i)
        {
            int tmp = arr[i];
            arr[i] = arr[minIndex];
            arr[minIndex] = tmp;
        }
    }
}
```

Time: O(n^2) worst/average/best. Space: O(1). Stable: Typically no (can be implemented stable with extra work).

--- 

## When to use
- Educational / small arrays: Bubble or Selection.
- For practical large inputs prefer efficient algorithms (merge/quick/heap).
