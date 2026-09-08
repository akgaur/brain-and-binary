### 📦 Carry Forward (in Arrays)

---

**Definition:**  
Carry Forward is a technique in array-based problems where information from a previous element is passed or retained for use in processing the current or upcoming elements. This avoids recomputation and is often used in prefix sums, running totals, dynamic programming, or optimizations.

**Purpose:**  
- Improves efficiency by reusing previously computed values  
- Reduces time complexity from O(n²) to O(n) in many cases

**Example:**

```csharp
// Calculate prefix sum using carry forward
int[] arr = {2, 4, 6, 8};
int[] prefixSum = new int[arr.Length];

prefixSum[0] = arr[0];  // base value

for (int i = 1; i < arr.Length; i++)
{
    prefixSum[i] = prefixSum[i - 1] + arr[i]; // carry forward previous sum
}

// Result: prefixSum = [2, 6, 12, 20]
```


### ⚠️ Important Point (When to Use Carry Forward Storage)

---

- If the information is **only required up to the current index** and **not reused multiple times**, then you can use a **single variable** to carry it forward.
  
- However, if the information needs to be **used multiple times** later in the solution (e.g., for range queries, comparisons, or DP transitions), then it is better to **store the information at each index** (e.g., in an array or list).

**Example Use Cases:**

- ✅ **Use a single variable**:  
  When you're tracking the **maximum element so far** and only need to compare it once.

- ✅ **Use an array for storage**:  
  When you're calculating **prefix sums**, and you'll need to query sums of subarrays multiple times.



### 🔁 Carry Forward Techniques in Arrays

Carry forward is a powerful technique where we retain useful information from previous computations while iterating over an array. This avoids redundant work and reduces time complexity, often from O(n²) to O(n).

---

#### ✅ 1. Sum (Prefix Sum) & (Suffix sum)

**Purpose:** To avoid recomputing the sum of elements repeatedly.

```csharp
prefixSum[i] = prefixSum[i - 1] + arr[i];

suffix[i] = suffix[i + 1] + arr[i];
```

#### ✅ 2. Running Product

**Purpose:**  
Maintain a cumulative product as you iterate, instead of recalculating it for every subarray.

```csharp
int product = 1;
for (int i = 0; i < arr.Length; i++)
{
    product *= arr[i]; // Carry forward the product
}
```

#### ✅ 3. Running Product

**Purpose:** 
Carry a boolean flag or state across iterations based on conditions.

```csharp
bool seenPositive = false;

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
        seenPositive = true;

    if (seenPositive)
        Console.WriteLine("After first positive: " + arr[i]);
}

```


#### ✅ 4. Index Tracking

**Purpose:** 
Track index positions of elements (e.g., first occurrence, last seen).

```csharp
Dictionary<int, int> firstIndex = new();

for (int i = 0; i < arr.Length; i++)
{
    if (!firstIndex.ContainsKey(arr[i]))
        firstIndex[arr[i]] = i; // Carry forward index info
}
```


#### ✅ 5. Count (Frequency)

**Purpose:** 
Keep a running count of specific elements or values that meet a condition.

```csharp
int count = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] == target)
        count++; // Carry forward total count
}

```

#### ✅ 6.Minimum / Maximum

**Purpose:** 
Track the running minimum or maximum as the array is traversed.

```csharp
int minSoFar = arr[0];
for (int i = 1; i < arr.Length; i++)
{
    minSoFar = Math.Min(minSoFar, arr[i]); // Carry forward min
}
```

### 📌 Find Shortest Subarray with Min and Max Elements

#### ✅ Problem Statement

Given an array of integers, return:

- The **smallest length** of a subarray that contains **both the minimum and maximum** elements of the array.
- The **start and end index** (0-based) of that subarray.

---


## 🧠 Approach 1: Use Prefix Arrays (Left to Right Tracking)

### 🧩 Idea

Instead of scanning in reverse, we can preprocess the input to **track positions** of max and min elements from the left.

1. Compute global `min` and `max` values.
2. Create two arrays:
   - `lastMinIndex[i]`: the last known index of the **min element** up to index `i`.
   - `lastMaxIndex[i]`: the last known index of the **max element** up to index `i`.
3. At each index `i`, check if both `lastMinIndex[i]` and `lastMaxIndex[i]` are valid.
4. Calculate and update the minimal subarray length using these indices.

---

## 📦 C# Implementation

```csharp
public class SubarrayMinMax
{
    public (int length, int start, int end) FindSubarrayUsingPrefixTracking(int[] arr)
    {
        int n = arr.Length;
        if (n == 0) return (0, -1, -1);

        int minVal = int.MaxValue;
        int maxVal = int.MinValue;

        // Step 1: Find global min and max
        foreach (int num in arr)
        {
            if (num < minVal) minVal = num;
            if (num > maxVal) maxVal = num;
        }

        if (minVal == maxVal)
            return (1, 0, 0); // All elements same

        int[] lastMinIndex = new int[n];
        int[] lastMaxIndex = new int[n];

        int lastMin = -1;
        int lastMax = -1;

        for (int i = 0; i < n; i++)
        {
            if (arr[i] == minVal) lastMin = i;
            if (arr[i] == maxVal) lastMax = i;

            lastMinIndex[i] = lastMin;
            lastMaxIndex[i] = lastMax;
        }

        int minLength = n;
        int start = 0, end = 0;

        for (int i = 0; i < n; i++)
        {
            if (lastMinIndex[i] != -1 && lastMaxIndex[i] != -1)
            {
                int s = Math.Min(lastMinIndex[i], lastMaxIndex[i]);
                int e = i;
                int len = e - s + 1;

                if (len < minLength)
                {
                    minLength = len;
                    start = s;
                    end = e;
                }
            }
        }

        return (minLength, start, end);
    }
}
```

#### 🧠 Approach 2: Space-Optimized Solution Without Auxiliary Arrays

1. Identify the **minimum** and **maximum** values in the array.
2. Traverse the array **from right to left**.
3. Track the **last seen index** of both the min and max elements.
4. Whenever both are found, calculate the subarray length and update the result if it's smaller than the current minimum.

---

#### 📦 Solution

```csharp
public class SubarrayMinMax
{
    public (int length, int start, int end) FindShortestSubarrayWithMinMax(int[] arr)
    {
        if (arr == null || arr.Length == 0)
            return (0, -1, -1);

		int min = int.MaxValue;
		int max = int.MinValue;

		foreach (int num in arr)
		{
			if (num < min)
				min = num;
			if (num > max)
				max = num;
		}		

        if (min == max)
            return (1, 0, 0); // All elements are the same

        int lastMinIndex = -1;
        int lastMaxIndex = -1;
        int minLength = arr.Length;
        int start = 0, end = 0;

        for (int i = arr.Length - 1; i >= 0; i--)
        {
            if (arr[i] == min)
                lastMinIndex = i;
            if (arr[i] == max)
                lastMaxIndex = i;

            if (lastMinIndex != -1 && lastMaxIndex != -1)
            {
                int currentStart = Math.Min(lastMinIndex, lastMaxIndex);
                int currentEnd = Math.Max(lastMinIndex, lastMaxIndex);
                int currentLength = currentEnd - currentStart + 1;

                if (currentLength <= minLength)
                {
                    minLength = currentLength;
                    start = currentStart;
                    end = currentEnd;
                }
            }
        }

        return (minLength, start, end);
    }
}
```