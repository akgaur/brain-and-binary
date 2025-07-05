## 📘 What is a Subarray?

### 🧾 Definition

A **subarray** is a **contiguous chunk** or sequence of elements within an array.

- It **must preserve order**
- It **must be continuous**
- The **whole array** itself is also a valid subarray

---

### 🧪 Example

Consider the array:

```csharp
int[] arr = { 1, 2, 3, 4 };
```

##### ✅ Valid Subarrays:

- `{1}`
- `{2, 3}`
- `{3, 4}`
- `{1, 2, 3, 4}` ← *(entire array is a subarray)*
- `{1, 2}`
- `{2, 3, 4}`

##### ❌ Invalid Subarrays (Non-contiguous):

- `{1, 3}` → *(not contiguous)*
- `{2, 4}` → *(not in order or continuous)*



## Question 📌 Print All Subarray Sums

### ✅ Problem Statement

Given an integer array, print the **sum of every possible subarray**.

A subarray is a **contiguous part** of an array.

---

### 🧠 Approach 1

Use two nested loops:
- The outer loop picks the **start index**.
- The inner loop picks the **end index** and maintains a **running sum**.
- Print or store the subarray sum for each valid window.

---

### 📦 C# Implementation

```csharp
public void PrintAllSubarraySums(int[] arr)
{
    int n = arr.Length;

    for (int start = 0; start < n; start++)
    {
        int sum = 0;

        for (int end = start; end < n; end++)
        {
            sum += arr[end];
            Console.WriteLine($"Subarray ({start}, {end}) Sum: {sum}");
        }
    }
}
```


### 🧠 Approach 2: Prefix Sum Array

We use an auxiliary array to store **prefix sums**, which helps us calculate any subarray sum in constant time.

### 🔧 Steps:
1. Create a `prefixSum` array such that:
   - `prefixSum[i]` = sum of elements from `arr[0]` to `arr[i]`
2. Use the formula:
   - `sum(i, j) = prefixSum[j] - prefixSum[i - 1]` (if `i > 0`)
   - `sum(0, j) = prefixSum[j]`

---

### 📦 C# Implementation

```csharp
public void PrintAllSubarraySumsWithPrefix(int[] arr)
{
    int n = arr.Length;
    int[] prefixSum = new int[n];
    prefixSum[0] = arr[0];

    for (int i = 1; i < n; i++)
        prefixSum[i] = prefixSum[i - 1] + arr[i];

    for (int start = 0; start < n; start++)
    {
        for (int end = start; end < n; end++)
        {
            int sum = start > 0 ? prefixSum[end] - prefixSum[start - 1] : prefixSum[end];
            Console.WriteLine($"Subarray ({start}, {end}) Sum: {sum}");
        }
    }
}
```