# Intermediate DSA : Arrays - Prefix Sum

## Overview 
**What is prefix sum** 
A **prefix sum** is an array where each element at index `i` stores the sum of all elements from index `0` to `i` in the original array.

**Example:**
```text
Original:   [2, 4, 6, 8]
Prefix Sum: [2, 6, 12, 20] → (2, 2+4, 2+4+6, 2+4+6+8)
```
**What is sufix sum**
		
A **suffix sum** is an array where each element at index `i` holds the sum of all elements from index `i` to the end of the original array.

**Example:**
```text
Original Array:    [2, 4, 6, 8]
Suffix Sum Array:  [20, 18, 14, 8]
```

## Question1. Given an array, does it contain an equilibrium point? Equilibrium: The sum of elements to the left of it is equal to the sum of elements to the right of it.


### 💡 Solution:

**Optimized Solution**
	Given an array of integers, create prefix array and check if there exists an **equilibrium point** —  
an index where the sum of all elements before it is equal to the sum of all elements after it.

**🔸 Approach**

1. Create a **prefix sum array**.
2. Loop through the original array.
3. For each index, calculate:
   - **Left sum** = prefix sum before the index.
   - **Right sum** = total sum - prefix sum up to the current index.
4. If left sum == right sum → equilibrium point found → return true.
5. If no such index exists → return false.


**🔸 Code (in C#)**

```csharp
public bool HasEquilibriumPoint(int[] arr)
{
	int totalSum = 0, leftSum = 0;

	foreach (int num in arr)
		totalSum += num;

	foreach (int num in arr)
	{
		totalSum -= num; // totalSum now acts as right sum

		if (leftSum == totalSum)
			return true;

		leftSum += num;
	}

	return false;
}
```
		
		  