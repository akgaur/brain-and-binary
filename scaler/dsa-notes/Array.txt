# Intermediate DSA: Introduction to Arrays

## 📌 Basic Properties of Arrays

- **Fixed Size** – Size is defined at creation and cannot change.
- **Same Data Type** – All elements must be of the same type.
- **Index-Based Access** – Access elements using 0-based indexing.
- **Contiguous Memory** – Elements are stored in continuous memory locations.
- **Fast Access, Slow Insert/Delete** – Access is fast (O(1)); insert/delete is slow (O(n)).

---

## ✅ Question 1: Write a piece of code to print all elements of an array

```csharp
int[] numbers = { 10, 20, 30, 40, 50 };
foreach (var num in numbers)
    Console.WriteLine(num);

		
## ✅ Question 2: Count the number of elements in the array that have at least one element greater than themselves.

### 💡 My Solution:

1. **Brute Force**  
   Pick each element and iterate through the entire array to check if there exists any element greater than the selected one.  
   **Time Complexity:** `O(N²)`

2. **Optimized Approach**  
   – First, find the maximum element in one pass.  
   – Then, in a second pass, count all elements that are smaller than the maximum element.  
   **Time Complexity:** `O(N)`  
   → Because if `x < y` and `y < z`, then `x` will always be less than `z`.


## ✅ Question 3: Given an array of elements and a number `k`, return `true` if there exists a pair `(i, j)` such that `arr[i] + arr[j] == k`.

### 💡 My Solution:

1. **Brute Force**  
   Generate all possible pairs and check if their sum equals `k`.  
   **Time Complexity:** `O(N²)`

2. **Optimized Approach**  
   – Use a HashSet to store the elements.  
   – For each element `x` in the array, check if `k - x` exists in the set.  
   – If yes, return `true`.  
   – Otherwise, add `x` to the set and continue.  
   **Time Complexity:** `O(N)`  
   **Space Complexity:** `O(N)`

### ✅ Example in C#

```csharp
bool HasPairWithSum(int[] arr, int k)
{
    HashSet<int> seen = new HashSet<int>();

    foreach (int num in arr)
    {
        if (seen.Contains(k - num))
            return true;

        seen.Add(num);
    }

    return false;
}

## ✅ Solution 3: Sort and Use Two-Pointer Technique

### 💡 Idea:
If the array is sorted, we can use two pointers (`left` and `right`) to find a pair whose sum equals `k`.

### 🔧 Steps:
1. Sort the array → `O(N log N)`
2. Initialize two pointers:
   - `left` at the beginning
   - `right` at the end
3. While `left < right`, do the following:
   - Calculate `sum = arr[left] + arr[right]`
   - If `sum == k`, return `true`
   - If `sum < k`, move `left++`
   - If `sum > k`, move `right--`

### 🕒 Time Complexity:
- **O(N log N)** for sorting
- **O(N)** for scanning
- **Overall:** `O(N log N)`

### 💻 C# Code:

```csharp
bool HasPairWithSum(int[] arr, int k)
{
    Array.Sort(arr); // Sort the array first (O(N log N))

    int left = 0, right = arr.Length - 1;

    while (left < right)
    {
        int sum = arr[left] + arr[right];

        if (sum == k)
            return true;
        else if (sum < k)
            left++;
        else
            right--;
    }

    return false;
}

 


## 🏁 Conclusion: Pair Sum Problem

When solving the problem:  
**"Given an array and a number `k`, check if there exists a pair of elements whose sum is exactly `k`."**

### ✅ Summary of All Valid Approaches:

| Approach         | Time Complexity | Space Complexity | Best Use Case                    |
|------------------|------------------|-------------------|----------------------------------|
| **Brute Force**   | O(N²)           | O(1)              | Simple but inefficient           |
| **HashSet**       | O(N)            | O(N)              | Best for **unsorted arrays**     |
| **Two-Pointer**   | O(N log N)      | O(1)              | Best for **sorted arrays**       |

---

### 🔍 Which One to Use?

- If the array is **unsorted** → use the **HashSet** approach (fastest overall).
- If the array is **sorted** or can be sorted efficiently → use the **Two-Pointer** approach to save space.

	

	