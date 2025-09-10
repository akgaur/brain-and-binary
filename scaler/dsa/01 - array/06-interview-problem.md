# 🧠 Problem 1: Longest Subarray of 1s

## 🧩 Problem Statement

Given an array consisting of only `0`s and `1`s, find the **length** of the **longest subarray** that contains only `1`s.

---

## ✅ Example

```txt
Input:  [1, 1, 0, 1, 1, 1]  
Output: 3
```
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



# 🧩 Problem Statement: Microsoft, LinkedIn

Given an array consisting of only `0`s and `1`s, find the **length** of the **longest subarray** that contains only `1`s after flipping minimum `0`s.

---

## ✅ Example

```txt
Input:  [1, 1, 0, 1, 1, 1]  
Output: 5
```
## 🧮 Solution (Pseudocode/C-style)
### Approach with axulary space 
-Create prefix array and suffix array to store the the max contigious array from left and right and when 0 encountered then swap the 0 with 1 who is byond its nebouhood

like : {1, 1, 0, 1, 1, 0, 0, 1, 1, 1, 1, 0, 1, 1, 1}

  
```csharp
int[] arr = {1, 1, 0, 1, 1, 0, 0, 1, 1, 1, 1, 0, 1, 1, 1};

int start = 0, currentStart = 0;
int end = 0, currentEnd = 0;
int zeroCount = 0, currentZeroCount = 0;

int maxLength = 0, currentLength = 0;

for (int i = 0; i < arr.Length; i++) {
    if (arr[i] == 1) {
        currentLength++;
        currentEnd = i;
    } else {
        currentLength = 0;
        zeroCount++;
        currentStart = i + 1; // reset to next index after 0
    }

    // Update the result only if a longer subarray is found
    if (currentLength > maxLength 
        && (currentZeroCount > zeroCount || currentZeroCount == 0)) {
        
        start = currentStart;
        end = currentEnd;
        maxLength = currentLength;
        zeroCount = currentZeroCount;

        currentZeroCount = 0; // reset to count the zero in the next possible answer
    }
}
```




# 🧩 Problem Statement: google

Given an array consisting of only `0`s and `1`s, find the **length** of the **longest subarray** that contains only `1`s after swapping from any `1`s in the array.

---

## ✅ Example

```txt
Input:  [1, 1, 0, 1, 1, 1, 0 , 1, 1,0 , 1]  
Output: 8
```
## 🧮 Solution (Pseudocode/C-style)
```csharp
int[] arr = {1, 1, 0, 1, 1, 0, 0, 1, 1, 1, 1, 0, 1, 1, 1};

int start = 0, currentStart = 0;
int end = 0, currentEnd = 0;
int zeroCount = 0, currentZeroCount = 0;

int maxLength = 0, currentLength = 0;

for (int i = 0; i < arr.Length; i++) {
    if (arr[i] == 1) {
        currentLength++;
        currentEnd = i;
    } else {
        currentLength = 0;
        zeroCount++;
        currentStart = i + 1; // reset to next index after 0
    }

    // Update the result only if a longer subarray is found
    if (currentLength > maxLength 
        && (currentZeroCount > zeroCount || currentZeroCount == 0)) {
        
        start = currentStart;
        end = currentEnd;
        maxLength = currentLength;
        zeroCount = currentZeroCount;

        currentZeroCount = 0; // reset to count the zero in the next possible answer
    }
}
```


# 🧩 Problem Statement: Microsoft, LinkedIn

- Given a binary array consisting only of 0s and 1s, count the number of triplets that satisfy the following conditions:
- A triplet consists of three elements: arr[i], arr[j], and arr[k] such that i < j < k.
- The values of the elements must follow the strictly increasing order: arr[i] < arr[j] < arr[k]
- The triplet elements do not need to be contiguous in the array.

---

## ✅ Example

we can do it using kednese algorithmn


## 🧮 Solution (Pseudocode/C-style)




# 🧩 Problem Statement: FAANG

- Given an array of size n, determine the maximum possible sum obtainable from any subarray of length k.

---

## ✅ Example

we can do it using kednese algorithmn

## 🧮 Solution (Pseudocode/C-style)