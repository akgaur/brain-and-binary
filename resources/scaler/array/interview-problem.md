# 🧠 Problem 1: Longest Subarray of 1s

## 🧩 Problem Statement

Given an array consisting of only `0`s and `1`s, find the **length** of the **longest subarray** that contains only `1`s.

---

## ✅ Example

```txt
Input:  [1, 1, 0, 1, 1, 1]  
Output: 3

Explanation: The longest subarray with only 1s is `[1, 1, 1]` with length 3.


##💡 Clarification
- Q: Which subarray to return if multiple subarrays have the same maximum length?
- A: Return the one that appears first (i.e., with the smallest starting index).

## 🧮 Solution (Pseudocode/C-style)

```c
int arr[] = {1, 1, 0, 1, 1, 0, 0, 1, 1, 1, 1, 0, 1, 1, 1};

int start = 0, currentStart = 0;
int end = 0, currentEnd = 0;

int maxLength = 0, currentLength = 0;

for (int i = 0; i < arr.Length; i++) {
    if (arr[i] == 1) {
        currentLength++;
        currentEnd = i;
    } else {
        currentLength = 0;
        currentStart = i + 1; // reset to next index after 0
    }

    // Update the result only if a longer subarray is found
    if (currentLength > maxLength) {
        start = currentStart;
        end = currentEnd;
        maxLength = currentLength;
    }
}
```

##📌 Final Output
- maxLength → Length of the longest subarray of 1s.

- start and end → Optional, if you want to return the actual subarray.

##📝 Notes
-This is a linear-time solution (O(n)), ideal for large arrays.

-If multiple longest subarrays exist, the algorithm picks the first one due to update condition on strict 