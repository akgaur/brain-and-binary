# Sorting: Concepts & Interview Questions

## Overview
Sorting is a fundamental operation in computer science, used to arrange data in a specific order (ascending or descending). It helps in efficient searching, data analysis, and solving complex problems.

---

## Question 1: Minimum Cost to Remove All Elements
Given an array of n elements, at every step remove an array element and calculate the cost of removing it (cost = sum of elements present in the array).

**Example:**
Array: [2, 1, 4]
- Remove 4 → cost = 2+1+4 = 7
- Remove 1 → cost = 4+1 = 5
- Remove 4 → cost = 4
Example:
```
if arrray is a,b,c,d then cost to remove all element
=> a+b+c+d
b+C+d
=> c+d
=> d

Index=> 0,1,2,3
Array=> a,b,c,d
```

=== > a*(0+1) + b*(1+1) + b*(2+1) + b*(3+1)

### 💡 Solution:
Sort the array in increasing order and remove elements one by one, accumulating the cost.

**C# Code:**
```csharp
public int MinRemovalCost(int[] arr)
{
    Array.Sort(arr);
    int cost = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        cost += arr[i] * (arr.Length - i);
    }
    return cost;
}
```

---

## Question 2: Nobel Integer
A Nobel integer is an element A[i] such that the number of elements less than A[i] is exactly A[i].

### 💡 Solution:
Sort the array and count the number of Nobel integers.

**C# Code:**
```csharp
public int CountNobelIntegers(int[] arr)
{
    Array.Sort(arr);
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if ((i == arr.Length - 1 || arr[i] != arr[i + 1]) && arr[i] == i)
            count++;
    }
    return count;
}
```

---

## Comparator: Custom Sorting in C#
Comparators are used to define custom sorting logic. In C#, use delegates or IComparer for custom sort.

---

## Question 3: Sort by Number of Factors
Sort the array in increasing order of the total number of factors. If two elements have the same number of factors, the smaller value comes first.

### 💡 Solution:
Count factors for each element and sort using a custom comparator.

**C# Code:**
```csharp
public int CountFactors(int n)
{
    int count = 0;
    for (int i = 1; i <= n; i++)
        if (n % i == 0) count++;
    return count;
}

public int[] SortByFactors(int[] arr)
{
    return arr.OrderBy(x => CountFactors(x)).ThenBy(x => x).ToArray();
}
```

---

## Question 4: Sort by Number of Digits
Sort the array in increasing order of number of digits. If two elements have the same number of digits, the greater value comes first.

### 💡 Solution:
Sort using a custom comparator based on digit count and value.

**C# Code:**
```csharp
public int DigitCount(int n)
{
    return n == 0 ? 1 : (int)Math.Floor(Math.Log10(Math.Abs(n)) + 1);
}

public int[] SortByDigits(int[] arr)
{
    return arr.OrderBy(x => DigitCount(x)).ThenByDescending(x => x).ToArray();
}
```