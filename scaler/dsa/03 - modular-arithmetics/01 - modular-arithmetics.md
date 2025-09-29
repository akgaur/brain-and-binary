# Modular Arithmetics: Concepts & Interview Questions

## Overview
Modular arithmetic is a system of arithmetic for integers, where numbers wrap around after reaching a certain value—the modulus. It is widely used in hashing, encryption, and solving mathematical problems in programming interviews.

### Key Concepts
- **Remainder Formula**: remainder = dividend - quotient * divisor
- **Largest Multiple**: quotient * divisor is the largest multiple of divisor ≤ dividend
- **Applications**: Hashmaps (consistent hashing), encryption, divisibility checks, etc.

### Divisibility Rules (up to 20)
- Rule for 3: Sum of digits must be divisible by 3
- Add more rules as needed for interview prep

---

## Question 1: Implement Power Function
Given integers `a`, `n`, and `p`, compute `(a^n) % p` efficiently.

### 💡 Solution:
Use fast exponentiation (modular exponentiation) to compute the result efficiently.

**C# Code:**
```csharp
public int PowerMod(int a, int n, int p)
{
    int result = 1;
    a = a % p;
    while (n > 0)
    {
        if ((n & 1) == 1)
            result = (int)(((long)result * a) % p);
        a = (int)(((long)a * a) % p);
        n >>= 1;
    }
    return result;
}
```

---

## Question 2: Array Representation Modulo
Given an array representing a number, return the value modulo `p` (e.g., p = 4).

**Example:**
Array: `[1,2,3,4,5,7]` → Number: 123457

### 💡 Solution:
Iterate through the array, build the number using modulo at each step to avoid overflow.

**C# Code:**
```csharp
public int ArrayMod(int[] arr, int p)
{
    int result = 0;
    foreach (int digit in arr)
    {
        result = (result * 10 + digit) % p;
    }
    return result;
}
```
