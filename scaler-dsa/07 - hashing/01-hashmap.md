# Hashmaps: Introduction & Key Concepts

## Overview
A hashmap is a data structure for key-value storage, providing fast lookup, insert, and delete operations (average O(1)).

---

## Key Concepts
- **Hash Function**: Maps keys to indices.
- **Collision Handling**: Chaining, open addressing.
- **Load Factor**: Controls resizing.

---

## Interview Approaches
- Frequency counting, duplicate detection.
- Two-sum, anagrams, grouping problems.
- Custom hash functions for objects.
- Edge cases: collisions, resizing, null keys/values.

---

## Question 1: How many distinct elements exist in the array?

### Solution 1: Hashmap Frequency
Count frequency of each element, then count unique keys.

**C# Code:**
```csharp
public int CountDistinctHashmap(int[] arr)
{
    Dictionary<int, int> freq = new Dictionary<int, int>();
    for (int i = 0; i < arr.Length; i++)
    {
        if (!freq.ContainsKey(arr[i])) freq[arr[i]] = 0;
        freq[arr[i]]++;
    }
    int count = 0;
    foreach (var kv in freq)
        count++;
    return count;
}
// Time: O(n), Space: O(n)
```

### Solution 2: Manual Set
Add all elements to a dictionary acting as a set.

**C# Code:**
```csharp
public int CountDistinctSet(int[] arr)
{
    Dictionary<int, bool> set = new Dictionary<int, bool>();
    for (int i = 0; i < arr.Length; i++)
        set[arr[i]] = true;
    return set.Count;
}
// Time: O(n), Space: O(n)
```

**Which is better?**
Both are O(n) and use extra space. The set approach is simpler if only distinct count is needed.

---

## Question 2: How many elements exist in array are uniquely existing?
Count elements that appear exactly once.

**C# Code:**
```csharp
public int CountUnique(int[] arr)
{
    Dictionary<int, int> freq = new Dictionary<int, int>();
    for (int i = 0; i < arr.Length; i++)
    {
        if (!freq.ContainsKey(arr[i])) freq[arr[i]] = 0;
        freq[arr[i]]++;
    }
    int count = 0;
    foreach (var kv in freq)
        if (kv.Value == 1) count++;
    return count;
}
// Time: O(n), Space: O(n)
```

---

## Question 3: Sum of ASCII values of a string
Given a string, find the sum of its ASCII values.

**C# Code:**
```csharp
public int AsciiSum(string s)
{
    int sum = 0;
    for (int i = 0; i < s.Length; i++)
        sum += (int)s[i];
    return sum;
}
// Time: O(n), Space: O(1)
```

---

## Question 4: Cache repeated query results (DP/Hashmap)
Given repeated queries for ASCII sum, cache results to avoid recalculation.

**C# Code:**
```csharp
public int CachedAsciiSum(string s, Dictionary<string, int> cache)
{
    if (cache.ContainsKey(s)) return cache[s];
    int sum = 0;
    for (int i = 0; i < s.Length; i++)
        sum += (int)s[i];
    cache[s] = sum;
    return sum;
}
// Time: O(n) per new query, O(1) for cached, Space: O(q) for q queries
```

**Which is better?**
Use caching if queries repeat often; otherwise, simple loop is sufficient.

---

## Question 5: First non-repeating element in array
Find the first element in the array that does not repeat.

**C# Code:**
```csharp
public int? FirstNonRepeating(int[] arr)
{
    Dictionary<int, int> freq = new Dictionary<int, int>();
    for (int i = 0; i < arr.Length; i++)
    {
        if (!freq.ContainsKey(arr[i])) freq[arr[i]] = 0;
        freq[arr[i]]++;
    }
    for (int i = 0; i < arr.Length; i++)
        if (freq[arr[i]] == 1) return arr[i];
    return null;
}
// Time: O(n), Space: O(n)
```

---

## Question 6: Check if there exists a subarray whose sum is 0
Use prefix sum and hashmap to detect duplicate prefix sums.

**Explanation:**
If any prefix sum repeats, the subarray between those indices sums to zero.

**C# Code:**
```csharp
public bool HasZeroSumSubarray(int[] arr)
{
    Dictionary<int, bool> seen = new Dictionary<int, bool>();
    int prefixSum = 0;
    seen[0] = true;
    for (int i = 0; i < arr.Length; i++)
    {
        prefixSum += arr[i];
        if (seen.ContainsKey(prefixSum)) return true;
        seen[prefixSum] = true;
    }
    return false;
}
// Time: O(n), Space: O(n)
```

---

## Question 7: Two Sum
Given an array, find if any two elements sum to a given value k.

### Solution 1: Brute Force
Check all pairs.

**C# Code:**
```csharp
public bool HasTwoSumBrute(int[] arr, int k)
{
    for (int i = 0; i < arr.Length; i++)
        for (int j = i + 1; j < arr.Length; j++)
            if (arr[i] + arr[j] == k) return true;
    return false;
}
// Time: O(n^2), Space: O(1)
```

### Solution 2: Hashmap
Store seen elements and check for complement.

**C# Code:**
```csharp
public bool HasTwoSumHash(int[] arr, int k)
{
    Dictionary<int, bool> seen = new Dictionary<int, bool>();
    for (int i = 0; i < arr.Length; i++)
    {
        int target = k - arr[i];
        if (seen.ContainsKey(target)) return true;
        seen[arr[i]] = true;
    }
    return false;
}
// Time: O(n), Space: O(n)
```

**Which is better?**
Hashmap approach is optimal for time, brute-force is only for small arrays or interview demonstration.

