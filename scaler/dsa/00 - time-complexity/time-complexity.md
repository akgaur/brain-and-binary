# Time Complexity: Introduction & Key Concepts

## ⏱️ What is Time Complexity?
- A measure of how the runtime of an algorithm grows as input size increases.
- Expressed using Big O notation (O(n), O(log n), etc).
- Helps compare efficiency of algorithms.

## 🔑 Key Concepts
- **Big O Notation**: Upper bound on growth rate.
- **Best, Average, Worst Case**: Different scenarios for input.
- **Space Complexity**: Memory usage as input grows.
- **Amortized Analysis**: Average time per operation over a sequence.

## 💡 MAANG Interview Approaches
- Analyze loops, nested loops, recursion.
- Compare brute force vs optimized solutions.
- Estimate time and space for edge cases.

---

## 📚 Classic Time Complexity Questions (Cracking the Coding Interview)

### 1. What is the time complexity of searching in a sorted array?
- **Answer:** O(log n) using binary search.

### 2. What is the time complexity of inserting an element in a linked list?
- **Answer:** O(1) if position is known; O(n) if searching for position.

### 3. What is the time complexity of finding the maximum element in an unsorted array?
- **Answer:** O(n)

### 4. What is the time complexity of traversing a binary tree?
- **Answer:** O(n) (visit each node once)

### 5. What is the time complexity of quicksort?
- **Answer:** Average O(n log n), Worst O(n²)

### 6. What is the time complexity of hash table operations?
- **Answer:** Average O(1), Worst O(n) (with collisions)

### 7. What is the time complexity of matrix multiplication (n x n)?
- **Answer:** O(n³)

### 8. What is the time complexity of finding all subsets of a set?
- **Answer:** O(2ⁿ)

### 9. What is the time complexity of merging two sorted arrays?
- **Answer:** O(n + m), where n and m are the sizes of the arrays.

### 10. What is the time complexity of reversing a string?
- **Answer:** O(n)

### 11. What is the time complexity of checking if a string is a palindrome?
- **Answer:** O(n)

### 12. What is the time complexity of finding the intersection of two unsorted arrays?
- **Answer:** O(n + m) using a hash set.

### 13. What is the time complexity of finding the shortest path in an unweighted graph?
- **Answer:** O(V + E) using BFS (V = vertices, E = edges).

### 14. What is the time complexity of heap sort?
- **Answer:** O(n log n)

### 15. What is the time complexity of finding the kth largest element in an array?
- **Answer:** O(n) using Quickselect (average case).

---

## 📝 Notes
- Always justify your time complexity analysis in interviews.
- Consider both time and space for optimal solutions.
