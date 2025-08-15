🧠 Problem 1: Maximum Subarray Sum (Kadane's Algorithm)
🧩 Problem Statement
Given an array A of size n, find the maximum possible sum of any non-empty contiguous subarray.
You must return the maximum sum among all subarrays.

This is a classic problem solved using Kadane’s Algorithm, which works in linear time O(n).

✅ Example
Input:

A = [-2, 1, -3, 4, -1, 2, 1, -5, 4]
Output:

6
Explanation:
The maximum sum subarray is [4, -1, 2, 1] with sum 4 + (-1) + 2 + 1 = 6.

💡 Optimal Approach: Kadane’s Algorithm
Idea:
Keep track of current subarray sum and update the global maximum sum.

If current sum becomes negative, reset it to 0.

👨‍💻 Solution (C-style Pseudocode)
c

int maxSubArray(int A[], int n) {
    int maxSum = A[0];
    int currSum = A[0];

    for (int i = 1; i < n; i++) {
        currSum = max(A[i], currSum + A[i]);
        maxSum = max(maxSum, currSum);
    }

    return maxSum;
}
🧠 Time & Space Complexity
Time Complexity: O(n)

Space Complexity: O(1)