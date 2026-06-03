
# **📘 Subarrays, Subsequences, and Subsets**

## **📑 Table of Contents**

1. Subarrays
2. Subsequences
3. Subsets
4. Comparison Table
5. Subset Sum Problem
6. Sum of All Subset Sums
7. Sum of Maximum of Subsequences

   ---

## **1\. Subarrays**

* **Definition:** A contiguous part of an array.
* Example: For array `[3, 6, 5, 7, 1, 2, 10]`
  * Subarray: `[5, 7, 1]`, `[2, 10]`
* Properties:
  * Must be contiguous.
  * Order is preserved.

 ---
## **2\. Subsequences**

* **Definition:** Any sequence derived by deleting **0 or more elements** without changing the order.

* Example: For `[3, 6, 5, 7, 1, 2, 10]`
  * `[5, 2, 10]`, `[3, 10]`, `[] (empty subsequence)`
* Not required to be contiguous, but order must be preserved.
* Example invalid subsequence: `[5, 4, 3]` (order not preserved).
🔹 **Note:**
* Every subarray is a subsequence.
* Not every subsequence is a subarray.
---
  ## **3\. Subsets**

* **Definition:** Same as subsequences but **order does not matter**.
* Contain unique elements only.
* Example: For `{1, 2, 3}`
  * Subsets: `{}`, `{1}`, `{2}`, `{3}`, `{1,2}`, `{2,3}`, `{1,3}`, `{1,2,3}`
* Subsets remain the same before and after sorting.

  ---

## **4\. Comparison Table**

| Feature | Subarray | Subsequence | Subset |
| ----- | ----- | ----- | ----- |
| Contiguous | ✅ Yes | ❌ No | ❌ No |
| Order Matters | ✅ Yes | ✅ Yes | ❌ No |
| Empty Allowed | ✅ Yes | ✅ Yes | ✅ Yes |
| After Sorting | May change | May change | Remains same |

  ---
## **5\. Subset Sum Problem**

**Problem:** Given an array of size `N` with distinct elements, check if there exists a subset with sum \= `K`.

### **Brute Force Approach:**
* Generate all subsets (`2^N`).
* Check if any subset sum equals `K`.
**Pseudo Code:**
`for i = 0 to (2^N - 1):`
    `sum = 0`
    `for j = 0 to N-1:`
        `if (i >> j) & 1 == 1:`
            `sum += arr[j]`
    `if sum == K:`
        `return true`
`return false`

**Time Complexity:** `O(2^N * N)`  
**Space Complexity:** `O(1)`

### **Optimized Approaches:**
* **Backtracking**
* **Dynamic Programming (Subset Sum DP)** → `O(N*K)`
---

## **6\. Sum of All Subset Sums**
**Problem:** Find the sum of sums of all subsets.

**Idea:**
* Each element contributes to multiple subsets.
* For an array of length `N`:
  * Each element appears in exactly `2^(N-1)` subsets.
* Contribution of element `x` \= `x * 2^(N-1)`

**Formula:**
`Sum of all subset sums = (arr[0] + arr[1] + ... + arr[N-1]) * 2^(N-1)`

**Example:**
* Array: `[1, 2, 3]`
* Subset sums: `0, 1, 2, 3, 3, 4, 5, 6`
* Total \= `24`
* Formula: `(1+2+3) * 2^(3-1) = 6 * 4 = 24 ✅`

**Time Complexity:** `O(N)`

---

## **7\. Sum of Maximum of Subsequences**
**Problem:** Given an array, find sum of maximum of all subsequences.

**Contribution Technique:**
* Each element contributes as maximum in some subsequences.
* For element `arr[i]`, count how many subsequences have it as maximum.

**Example:**
* Array: `[1, 2, 3, 4, 5]`
* Contribution of `5` → in all subsequences (since it’s largest).
* Contribution of `4` → in subsequences where no `5` exists.

**Approach:**
* Sort array if needed.
* For each element, calculate contribution using bit logic or combinatorics.

**Complexity:** `O(N log N)` (with sorting).

---

✅ **Key Takeaways:**
* Subarray \= contiguous sequence.
* Subsequence \= order preserved, not contiguous.
* Subset \= order doesn’t matter.
* Subset sum problem solvable by bitmask, backtracking, DP.
* Sum of all subset sums formula uses contributions.
* Contribution technique helps in advanced subsequence problems.