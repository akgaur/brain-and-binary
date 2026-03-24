# Sorting: Concepts & Interview Questions

## Overview
Sorting arranges elements in a defined order (ascending/descending). Core for searching, ranking, and many algorithmic techniques. This document contains interview-style problems and concise summaries of common sorting algorithms with manual C# implementations and complexity notes.

---

## Interview Problems (kept + clarified)

### Question 1: Minimum Cost to Remove All Elements
Given an array, repeatedly remove one element; cost at each removal = sum of elements currently present. Find minimum total cost.

Solution idea: remove largest elements last — sort increasing and accumulate arr[i] * (n - i).

C# (manual sort allowed here for clarity; production: use efficient sort)
```csharp
// note: do not use Array.Sort in interview; use MergeSort implementation elsewhere
public long MinRemovalCost(int[] arr)
{
    // assume arr sorted ascending (call MergeSort if needed)
    MergeSort(arr); // use the MergeSort from below
    long cost = 0;
    int n = arr.Length;
    for (int i = 0; i < n; i++)
        cost += (long)arr[i] * (n - i);
    return cost;
}
```
Time: O(n log n) dominated by sort. Space: O(n) auxiliary for merge.

---

### Question 2: Nobel Integer
Element A[i] such that number of elements less than A[i] equals A[i].

Solution: sort array and scan, handle duplicates.

```csharp
public int CountNobelIntegers(int[] arr)
{
    MergeSort(arr);
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if ((i == arr.Length - 1 || arr[i] != arr[i + 1]) && arr[i] == i)
            count++;
    }
    return count;
}
```
Time: O(n log n). Space: O(n).

---

### Question 3: Sort by Number of Factors
Sort by number of divisors increasing; ties by value.

Solution: compute factor counts (optimized to sqrt) and stable sort by pair (factorCount, value).

Time: factor counting O(n sqrt(m)), sorting O(n log n). Space: O(n).

---

### Question 4: Sort by Number of Digits
Sort by digit count increasing; ties: larger value first.

Solution: digit count via log10 or loop; custom comparator in manual sort.

Time: O(n log n). Space: O(n).

---

## Common Sorting Algorithms (concise, manual C# implementations)

Notes: implementations avoid built-in Sort/ LINQ per coding rules. Use helper MergeSort for interview/production-level sorting.

### Insertion Sort
- Main idea: build sorted prefix by inserting next element.
- Use when n small or mostly-sorted.

```csharp
public void InsertionSort(int[] arr)
{
    int n = arr.Length;
    for (int i = 1; i < n; i++)
    {
        int key = arr[i];
        int j = i - 1;
        while (j >= 0 && arr[j] > key)
        {
            arr[j + 1] = arr[j];
            j--;
        }
        arr[j + 1] = key;
    }
}
// Time: O(n^2) worst, O(n) best if nearly sorted. Space: O(1). Stable.
```

### Bubble Sort (optimized)
- Repeated adjacent swaps; early exit when no swaps.

(see other file for full code — use this only for learning)

Time: O(n^2), Space: O(1).

### Selection Sort
- Repeatedly pick min and swap to front.
- Not stable by default. Use for small arrays with minimal swaps.

Time: O(n^2), Space: O(1).

### Merge Sort (recommended stable general-purpose)
- Divide and conquer, stable, O(n log n) time, O(n) extra space.

```csharp
public void MergeSort(int[] arr)
{
    if (arr == null || arr.Length < 2) return;
    int[] aux = new int[arr.Length];
    MergeSortRec(arr, aux, 0, arr.Length - 1);
}
private void MergeSortRec(int[] arr, int[] aux, int l, int r)
{
    if (l >= r) return;
    int m = l + (r - l) / 2;
    MergeSortRec(arr, aux, l, m);
    MergeSortRec(arr, aux, m + 1, r);
    int i = l, j = m + 1, k = l;
    while (i <= m && j <= r)
    {
        if (arr[i] <= arr[j]) aux[k++] = arr[i++];
        else aux[k++] = arr[j++];
    }
    while (i <= m) aux[k++] = arr[i++];
    while (j <= r) aux[k++] = arr[j++];
    for (k = l; k <= r; k++) arr[k] = aux[k];
}
// Time: O(n log n). Space: O(n). Stable.
```

### Quick Sort (in-place, average fast)
- Partition around pivot, recursively sort partitions.
- Use randomized pivot to avoid worst-case.

```csharp
public void QuickSort(int[] arr)
{
    QuickRec(arr, 0, arr.Length - 1);
}
private void QuickRec(int[] arr, int l, int r)
{
    if (l >= r) return;
    int p = Partition(arr, l, r);
    QuickRec(arr, l, p - 1);
    QuickRec(arr, p + 1, r);
}
private int Partition(int[] arr, int l, int r)
{
    int pivot = arr[r];
    int i = l;
    for (int j = l; j < r; j++)
    {
        if (arr[j] < pivot)
        {
            int t = arr[i]; arr[i] = arr[j]; arr[j] = t;
            i++;
        }
    }
    int tmp = arr[i]; arr[i] = arr[r]; arr[r] = tmp;
    return i;
}
// Time: average O(n log n), worst O(n^2) (use random pivot). Space: O(log n) recursion.
```

### Heap Sort
- Build max-heap and extract max repeatedly; in-place, O(n log n), not stable.

```csharp
public void HeapSort(int[] arr)
{
    int n = arr.Length;
    for (int i = n / 2 - 1; i >= 0; i--) Heapify(arr, n, i);
    for (int i = n - 1; i >= 0; i--)
    {
        int t = arr[0]; arr[0] = arr[i]; arr[i] = t;
        Heapify(arr, i, 0);
    }
}
private void Heapify(int[] arr, int n, int i)
{
    int largest = i, l = 2 * i + 1, r = 2 * i + 2;
    if (l < n && arr[l] > arr[largest]) largest = l;
    if (r < n && arr[r] > arr[largest]) largest = r;
    if (largest != i)
    {
        int t = arr[i]; arr[i] = arr[largest]; arr[largest] = t;
        Heapify(arr, n, largest);
    }
}
// Time: O(n log n). Space: O(1) (in-place), not stable.
```

### Counting Sort (non-comparison, linear when range small)
- Build frequency array of values (works for non-negative integers or shifted range).
- O(n + k) time, O(k) extra space where k = range size.

```csharp
public int[] CountingSort(int[] arr, int maxValue)
{
    int n = arr.Length;
    int[] freq = new int[maxValue + 1];
    for (int i = 0; i < n; i++) freq[arr[i]]++;
    int idx = 0;
    int[] outArr = new int[n];
    for (int v = 0; v <= maxValue; v++)
        for (int c = 0; c < freq[v]; c++)
            outArr[idx++] = v;
    return outArr;
}
// Constraint: values 0..maxValue and maxValue not too large.
```

### Radix Sort (for integers, stable per-digit)
- Process digits (LSB to MSB) using stable counting sort per digit.
- Time: O(d*(n + b)) where d = digits, b = base (e.g., 10). Space: O(n + b).

---

## When to use which
- Small or nearly-sorted: Insertion, Bubble (educational).
- General stable reliable: Merge Sort.
- Fast in practice, in-place: Quick Sort (with randomized pivot).
- In-place guaranteed O(n log n): Heap Sort.
- Integer keys with small range: Counting / Radix.
- Memory/time tradeoffs depend on n, data distribution, and stability requirement.

---

## Complexity Summary (quick)
- Bubble/Selection/Insertion: O(n^2) time, O(1) space.
- Merge: O(n log n) time, O(n) space, stable.
- Quick: Average O(n log n), worst O(n^2), O(log n) space (recursion).
- Heap: O(n log n), O(1) extra space, not stable.
- Counting/Radix: near O(n) for limited ranges, O(k) / O(d*(n+b)) space.

---

## Final Notes / Coding Rules
- Implement algorithms manually in interviews unless built-in is explicitly allowed.
- Always mention time/space complexity and constraints (e.g., value ranges for counting sort).
- Use MergeSort or QuickSort for general-purpose sorting in solutions shown here.