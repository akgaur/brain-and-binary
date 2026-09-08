# Recursion: Introduction & Key Concepts

---

## Overview
Recursion is a technique where a function calls itself to solve subproblems. It is widely used in divide & conquer algorithms, tree/graph traversals, and backtracking.

---

## Key Concepts (3 Steps of Recursion)
- **Base Case**: Prevents infinite recursion by providing a stopping condition.
- **Stack Overflow**: Occurs if recursion is too deep or lacks a base case.
- **Tail Recursion**: Recursive call is the last operation in the function.
- **Backtracking**: Systematically searches for solutions by exploring all possibilities.

---

## MAANG Interview Approaches
- Classic problems: factorial, Fibonacci, permutations, combinations.
- Divide & conquer: merge sort, quick sort, binary search.
- Tree/graph traversals: DFS, subset generation.
- Edge cases: empty input, single element, deep recursion.

---

## Topic: Recursion I

### Definition
Recursion is a function calling itself to solve a problem using smaller instances of the same problem.

---

### Example 1: Sum of N Natural Numbers
**Problem:** Find sum of first `N` natural numbers.

**Steps:**
1. **Assumption:** `sum(N)` returns sum of first `N` numbers.
2. **Recursive Relation:** `sum(N) = N + sum(N-1)`
3. **Base Condition:** If `N == 0`, return 0.

**C# Code:**
```csharp
public int Sum(int N)
{
    if (N == 0) return 0;
    return N + Sum(N - 1);
}
```
**Time Complexity:** O(N)
**Space Complexity:** O(N) (recursion stack)

---

### Example 2: Factorial
**Problem:** Find factorial of `N`.

**Steps:**
1. **Assumption:** `fact(N)` returns `N!`.
2. **Recursive Relation:** `fact(N) = N * fact(N-1)`
3. **Base Condition:** If `N == 0`, return 1.

**C# Code:**
```csharp
public int Fact(int N)
{
    if (N == 0) return 1;
    return N * Fact(N - 1);
}
```
**Dry Run:** `Fact(5) = 5 * 4 * 3 * 2 * 1 = 120`
**Time Complexity:** O(N)
**Space Complexity:** O(N)

---

### Example 3: Fibonacci
**Problem:** Find Nth Fibonacci number.

**Sequence:** 0, 1, 1, 2, 3, 5, 8, 13, ...

**Recursive Relation:**
- `fib(N) = fib(N-1) + fib(N-2)`
- Base: `fib(0) = 0`, `fib(1) = 1`

**C# Code:**
```csharp
public int Fib(int N)
{
    if (N == 0) return 0;
    if (N == 1) return 1;
    return Fib(N - 1) + Fib(N - 2);
}
```
**Time Complexity:** O(2^N) (due to repeated calls)
**Space Complexity:** O(N)

---

### Example 4: File System Search
**Problem:** Check if a file exists in a directory structure.

**Steps:**
1. `fetchDir(X)`: List sub-directories of X.
2. `fetchFiles(X)`: List files inside directory X.
3. Search:
   - If file in `fetchFiles(dir)`, return true.
   - Else, recursively search in subdirectories.

**Pseudocode:**
```csharp
public bool IsFileExists(Dir dir, string filename)
{
    if (fetchFiles(dir).Contains(filename))
        return true;
    foreach (var subdir in fetchDir(dir))
        if (IsFileExists(subdir, filename))
            return true;
    return false;
}
```
**Time Complexity:** O(total files + directories)
**Space Complexity:** O(depth of directory tree)
