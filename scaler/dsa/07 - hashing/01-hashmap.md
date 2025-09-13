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

## Question 1: Count Distinct Elements in Array
Given an array of n elements, count the number of distinct elements.

### 💡 Solution 1: Using Hashmap
Manually store each element in a dictionary and count unique keys.

**C# Code:**
```csharp
public int CountDistinct(int[] arr)
{
    Dictionary<int, bool> map = new Dictionary<int, bool>();
    for (int i = 0; i < arr.Length; i++)
    {
        if (!map.ContainsKey(arr[i]))
            map[arr[i]] = true;
    }
    return map.Count;
}
// Time: O(n), Space: O(n)
```

### 💡 Solution 2: Using Set
Manually implement a set using a dictionary.

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

---

## Question 2: Count Unique Elements (Frequency = 1)
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

## Question 3: Sum of ASCII Values of a String
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

## Question 4: Cache Repeated Query Results (DP/Hashmap)
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

---

## Question 5: First Non-Repeating Element in Array
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

## Question 6: Subarray with Sum Zero
Check if there exists a subarray whose sum is zero.

### 💡 Solution:
Use prefix sum and a set (dictionary) to detect duplicates.

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

**C# Code:**
```csharp
public bool HasTwoSum(int[] arr, int k)
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

