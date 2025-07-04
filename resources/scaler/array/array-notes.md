# Intermediate DSA: Introduction to Arrays

## 📌 Basic Properties of Arrays

- **Fixed Size** – Size is defined at creation and cannot change.
- **Same Data Type** – All elements must be of the same type.
- **Index-Based Access** – Access elements using 0-based indexing.
- **Contiguous Memory** – Elements are stored in continuous memory locations.
- **Fast Access, Slow Insert/Delete** – Access is fast (O(1)); insert/delete is slow (O(n)).

---

## ✅ Question 1: Write a piece of code to print all elements of an array

### 💡 Solution:

	```csharp
	int[] numbers = { 10, 20, 30, 40, 50 };
	foreach (var num in numbers)
		Console.WriteLine(num);
	```
		
## ✅ Question 2: Count the number of elements in the array that have at least one element greater than themselves.

### 💡 Solution:

1. **Brute Force**  
   Pick each element and iterate through the entire array to check if there exists any element greater than the selected one.  
   **Time Complexity:** `O(N²)`

2. **Optimized Approach**  
   – First, find the maximum element in one pass.  
   – Then, in a second pass, count all elements that are smaller than the maximum element.  
   **Time Complexity:** `O(N)`  
   → Because if `x < y` and `y < z`, then `x` will always be less than `z`.


## ✅ Question 3: Given an array of elements and a number `k`, return `true` if there exists a pair `(i, j)` such that `arr[i] + arr[j] == k`.

### 💡 Solution:

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
			var seen = new HashSet<int>();
			foreach (var num in arr)
				if (seen.Contains(k - num)) return true;
				else seen.Add(num);
			return false;
		}

	```

3. **Sort and Use Two-Pointer Technique**

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
			Array.Sort(arr);//we need to write the sorting algirithm in interview if we are using this approach
			for (int i = 0, j = arr.Length - 1; i < j;)
			{
				int sum = arr[i] + arr[j];
				if (sum == k) return true;
				if (sum < k) i++; else j--;
			}
			return false;
		}

	```
 

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

	

## ✅ Question 4: Reverse the array. variation of the question => You are given start, end index you just need to reverse within the range only rest array will stay same

### 💡 Solution: 

1. **Brute Force** 

	** 🖨️ If You Only Need to Print in Reverse:**
	- Start iterating from the **last index to the first**.
	- Print each element as you go.
	- ✅ No need to modify or reverse the array in memory.

	** 🔄 If You Need to Return a Reversed Array:**
	- Use **auxiliary space** (like a new array or list).
	- Insert elements in reverse order into the new structure.
	- ✅ Useful when the reversed array needs to be used further in code.
	
2. **Optimized Approach**  
	
	To reverse the array efficiently, use the **two-pointer technique**:
	- Initialize two pointers: one at the **start** and one at the **end** of the array.
	- Swap the elements at these two positions.
	- Move the pointers inward (`start++`, `end--`) and repeat until they meet.

	✅ This reverses the array **in-place** without using extra space.
	
	```csharp
	    int srart = 0;// give srart index 
		int end = arr.Length - 1; //give end index here
		void Reverse(int[] arr)
		{
			for (int i = srart, j = end; i < j; i++, j--)
				(arr[i], arr[j]) = (arr[j], arr[i]);
		}
	```
