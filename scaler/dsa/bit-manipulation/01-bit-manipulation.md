--------------- Format to be used 
# Intermediate DSA: Bit Manipulation

## 📌 What is a Number System?
- A number system defines how numbers are represented using digits and a base.
- Common systems: **Binary (base 2)**, **Octal (base 8)**, **Decimal (base 10)**, **Hexadecimal (base 16)**.
- Conversion between bases is a frequent interview topic.

### 🔄 Example: Convert Binary to Decimal
```csharp
string binary = "1011";
int decimalValue = Convert.ToInt32(binary, 2); // Output: 11
```

---

## 📝 Notes
- XOR is useful for finding unique elements and toggling bits.
- Bit manipulation is efficient for low-level operations and interview questions.
---

## 📌 Bitwise Operators
- **AND (&)**: Sets each bit to 1 if both bits are 1.
- **OR (|)**: Sets each bit to 1 if one of two bits is 1.
- **XOR (^)**: Sets each bit to 1 if only one of two bits is 1.
- **NOT (~)**: Inverts all the bits.
- **Left Shift (<<)**: Shifts bits to the left, adds zeros on the right.
- **Right Shift (>>)**: Shifts bits to the right, drops bits on the right.

---

## ✅ Question 1: Find the Number Occurring Odd Number of Times
Given an array where every number appears an even number of times except one, find that number.

### 💡 Solution:
- XOR all elements. The result is the odd-occurring number.

```csharp
int FindOdd(int[] arr)
{
    int res = 0;
    foreach (var num in arr)
        res ^= num;
    return res;
}
```

---

## ✅ Question 2: Check if a Bit is Set or Unset
Given a number `n` and position `i`, check if the bit at position `i` is set (1) or unset (0).

### 💡 Solution:
- Use left shift and bitwise AND.

```csharp
bool IsBitSet(int n, int i)
{
    return (n & (1 << i)) != 0;
}
```
Or using right shift:
```csharp
bool IsBitSet(int n, int i)
{
    return ((n >> i) & 1) == 1;
}
```

---

## ✅ Question 3: Toggle a Bit at Position i
Given number `n` and position `i`, toggle the bit at position `i`.

### 💡 Solution:
- Use XOR with a mask.

```csharp
int ToggleBit(int n, int i)
{
    return n ^ (1 << i);
}
```

---

## ✅ Question 4: Toggle All Bits Starting from Rightmost Set Bit
Given number `n`, toggle all bits from the rightmost set bit.

### 💡 Solution:
- Find rightmost set bit and toggle all bits from there.

```csharp
int ToggleFromRightmostSetBit(int n)
{
    int mask = n & -n; // Isolate rightmost set bit
    return n ^ ((mask << 1) - 1);
}
```

---

## ✅ Question 5: Construct a Binary Number with x Set Bits and y Unset Bits
Create a number with `x` set bits followed by `y` unset bits.

### 💡 Solution:
- Use left shift and subtraction.

```csharp
int ConstructNumber(int x, int y)
{
    return ((1 << x) - 1) << y;
}
```

---

## ✅ Question 6: Get Bit Dropped by Shift
Find the bit value that is dropped when shifting left or right.

### 💡 Solution:
- **Right Shift:** Use modulus operator to get LSB.
- **Left Shift:** Use bitmask to get MSB.

```csharp
int DroppedRightBit(int n)
{
    return n % 2;
}
int DroppedLeftBit(int n, int bitLength, int shift)
{
    int mask = ((1 << shift) - 1) << (bitLength - shift);
    return (n & mask) >> (bitLength - shift);
}
```

---

## ✅ Question 7: Add Two Binary Strings and Return Decimal
Given two binary strings, add them and return the decimal result.

### 💡 Solution:

```csharp
int AddBinaryStrings(string a, string b)
{
    int num1 = Convert.ToInt32(a, 2);
    int num2 = Convert.ToInt32(b, 2);
    return num1 + num2;
}
```

---

## ✅ Question 8: Find x such that A ^ x is Minimum
Given number `A`, find `x` such that `A ^ x` is minimized.

### 💡 Solution:
- The minimum is achieved when `x = A` (since `A ^ A = 0`).

```csharp
int MinXor(int A)
{
    return A;
}
```

