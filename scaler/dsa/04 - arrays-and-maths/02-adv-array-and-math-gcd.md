# 🧮 GCD (Greatest Common Divisor)

The GCD of two numbers is the largest integer that divides both numbers without leaving a remainder.

## ✅ Definition
- gcd(a, b) = x
- `a % x == 0`
- `b % x == 0`
- `x` is the greatest such value

## 🔍 Special cases

### 1) Involving 0
- `gcd(0, n) = |n|` for non-zero `n`
- `0` is divisible by any non-zero integer

Example:
- `gcd(0, 18) = 18`

### 2) Negative numbers
- gcd is always non-negative
- `gcd(-a, b) = gcd(a, b)`

Example:
- factors of `-5`: `-5`, `5`
- gcd is `5`

## ⚙️ Brute-force approach

```c
A = abs(A);
B = abs(B);
for (i = min(A,B); i >= 1; i--) {
    if (A % i == 0 && B % i == 0) return i;
}
```

- time complexity: `O(min(A,B))`
- can be improved with sqrt scanning, but still slow for large values

## 🚀 Best approach: Euclidean algorithm

### 1) Subtraction version

```
function gcd(a, b):
  a = abs(a)
  b = abs(b)
  if a < b then swap(a, b)
  while b != 0:
    a = a - b
    if a < b then swap(a, b)
  return a
```

### 2) Modulo (preferred)

```
function gcd(a, b):
  a = abs(a)
  b = abs(b)
  while b != 0:
    temp = b
    b = a % b
    a = temp
  return a
```

- time complexity: `O(log(min(a,b)))`
- much faster than brute-force and sqrt-based loops

## 📌 Example walk-through

`gcd(400, 300)` using subtraction-style (approx):
- `gcd(400, 300)` → `gcd(100, 300)`
- `gcd(300, 100)` → `gcd(200, 100)`
- `gcd(100, 100)` → `gcd(0, 100)` → return `100`

Only 4 calls in this sample, compared to ~17 iterations for naive sqrt method.



