# Arrays & Maths: Introduction & Key Concepts

## Overview
Arrays are contiguous memory structures with fixed size and index-based access. They offer fast access but slow insert/delete operations.

---

## Key Concepts
- **Prefix Sum**: Fast range queries.
- **Sliding Window**: Efficient subarray problems.
- **Two Pointer**: Pair and subarray search.
- **Sorting**: In-place, stable, unstable.

---

## MAANG Interview Approaches
- Subarray sum, pair sum, frequency counting.
- Mathematical patterns: GCD, LCM, primes, modular arithmetic.
- Practice edge cases: empty array, duplicates, large numbers.

---

## Question 1: Majority Element (> n/2 frequency)
Given an array of size n (positive numbers), return if any number exists whose frequency > n/2.

**Example:**
Array: `[1,6,1,1,2,1]` → Majority element is 1 (frequency 4 > 6/2)

### 💡 Solution (Moore's Voting Algorithm):
Find a candidate and verify its frequency.

**C# Code:**
```csharp
public int? FindMajorityElement(int[] arr)
{
    int candidate = 0, count = 0;
    foreach (int num in arr)
    {
        if (count == 0)
        {
            candidate = num;
            count = 1;
        }
        else if (num == candidate)
            count++;
        else
            count--;
    }
    count = 0;
    foreach (int num in arr)
        if (num == candidate) count++;
    return count > arr.Length / 2 ? candidate : (int?)null;
}
```

---

## Question 2: Josephus Problem
Given n people standing in a circle, every second person is eliminated until one remains. Find the position of the survivor.

### 💡 Solution:
Use recursion or iteration to find the survivor's position.

**C# Code:**
```csharp
public int Josephus(int n)
{
    int res = 0;
    for (int i = 2; i <= n; i++)
        res = (res + 2) % i;
    return res + 1; // 1-based index
}
```



