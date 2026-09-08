# Advanced Sorting: Merge Sort & Inversion Count

## Merge Sort
Merge sort is a divide-and-conquer algorithm:
1. Divide the array into two halves.
2. Recursively sort each half.
3. Merge the two sorted halves.

Merge is linear time; overall complexity is O(n log n).

### C# Implementation (top-level wrapper + helper)
```csharp
public void MergeSort(int[] arr)
{
    if (arr == null || arr.Length < 2) return;
    int[] aux = new int[arr.Length];
    MergeSortRec(arr, aux, 0, arr.Length - 1);
}

private void MergeSortRec(int[] arr, int[] aux, int left, int right)
{
    if (left >= right) return;
    int mid = left + (right - left) / 2;
    MergeSortRec(arr, aux, left, mid);
    MergeSortRec(arr, aux, mid + 1, right);
    Merge(arr, aux, left, mid, right);
}

private void Merge(int[] arr, int[] aux, int left, int mid, int right)
{
    int i = left, j = mid + 1, k = left;
    while (i <= mid && j <= right)
    {
        if (arr[i] <= arr[j]) aux[k++] = arr[i++];
        else aux[k++] = arr[j++];
    }
    while (i <= mid) aux[k++] = arr[i++];
    while (j <= right) aux[k++] = arr[j++];
    for (k = left; k <= right; k++) arr[k] = aux[k];
}
```

Time: O(n log n) worst/average/best. Space: O(n) auxiliary. Stable: Yes (as implemented).

---

## Inversion Count
An inversion is a pair (i, j) such that i < j and arr[i] > arr[j]. Number of inversions equals minimum adjacent swaps to sort.

### Brute-force
Check all pairs (i < j) — O(n^2).

### Optimized: using merge-sort
Count inversions while merging: when an element from right half is placed before remaining left-half elements, it contributes (mid - i + 1) inversions.

### C# Implementation (returns long)
```csharp
public long InversionCount(int[] arr)
{
    if (arr == null || arr.Length < 2) return 0;
    int[] aux = new int[arr.Length];
    return InvRec(arr, aux, 0, arr.Length - 1);
}

private long InvRec(int[] arr, int[] aux, int left, int right)
{
    if (left >= right) return 0;
    int mid = left + (right - left) / 2;
    long count = 0;
    count += InvRec(arr, aux, left, mid);
    count += InvRec(arr, aux, mid + 1, right);
    count += InvMerge(arr, aux, left, mid, right);
    return count;
}

private long InvMerge(int[] arr, int[] aux, int left, int mid, int right)
{
    int i = left, j = mid + 1, k = left;
    long invCount = 0;
    while (i <= mid && j <= right)
    {
        if (arr[i] <= arr[j]) aux[k++] = arr[i++];
        else
        {
            aux[k++] = arr[j++];
            invCount += (mid - i + 1); // all remaining in left from i..mid are inversions
        }
    }
    while (i <= mid) aux[k++] = arr[i++];
    while (j <= right) aux[k++] = arr[j++];
    for (k = left; k <= right; k++) arr[k] = aux[k];
    return invCount;
}
```

Complexities:
- Brute: O(n^2) time, O(1) space.
- Merge-based: O(n log n) time, O(n) space.

--- 

## Notes
- Use merge-based inversion count for large arrays.
- Keep indices and long for counts when n is large.