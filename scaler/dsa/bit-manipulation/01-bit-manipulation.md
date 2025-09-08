--------------- Format to be used 
# Intermediate DSA: Introduction to Arrays

## 📌 Basic Properties of Arrays

- **Fixed Size** – Size is defined at creation and cannot change.
- **Same Data Type** – All elements must be of the same type.
- **Index-Based Access** – Access elements using 0-based indexing.
- **Contiguous Memory** – Elements are stored in continuous memory locations.
- **Fast Access, Slow Insert/Delete** – Access is fast (O(1)); insert/delete is slow (O(n)).

---

## ✅ Question 1: Write a piece of code to print all elements of an array

### 💡 Solution:

```csharp
int[] numbers = { 10, 20, 30, 40, 50 };
foreach (var num in numbers)
	Console.WriteLine(num);
```
reove after document prep
---------------------


# Overview of number system
- what is number system, base of a number system
- octal, decimal, hexadecimal, binary number system
- conversion of a number from one base to another base
- Convert binary to decimal, decimal to hexadecimal, and other

# Binary number system
-------------------
- Bitwise operatin and, or, xor.
- xor importent and its properties 
- set bit short code in c#
- unset bit short code in c#
- is set Bit short code in c#


## ✅ Question 1: Given an array of intergers where every number is present even number of times but one number is present odd number of times, find the number 

### 💡 Solution:
 - Take xor of each element of array and return the result
 - as x^x gives 0, and 0 ^ x gives x, 

```csharp
Code here
```




## ✅ Question 2: Given an array of intergers where every number is present even number of times but one number is present odd number of times, find the number 

### 💡 Solution Optimised Approach:
 - Take xor of each element of array and return the result
 - as x^x gives 0, and 0 ^ x gives x, 

```csharp
Code here
```

# Left shift and right shift
- left shift(<<) and right shift( >>) how does it work ? 

# Question: Check if bit is set or unset using left shift

### 💡 Solution Optimised Approach:
 - take left shift of one and then take and 
 - if it gives 0 then it set otherwise it is unset 
 - add multple sollution in short and clean and keep main logic

```csharp
Code here = (1<<i & num) == 0 ? unset : set  
or n >> i & 1 == 1 ? return set: unset;
```

# Question: Given number n and position i toggle a bit of a number at given position i

### 💡 Solution Optimised Approach:
 -

```csharp
Code here 
```

# Question: Given number n toggle all the bits starting from right most set bit.

### 💡 Solution Optimised Approach:
 -

```csharp
Code here 
```
# Question: Cunduct a binary number of given x number of set bits and y number of unset bit
- (x set bits y unset bits)

### 💡 Solution Approach: using loop
 -create nuber with 0 and then create using 1

```csharp
Code here 
```

### 💡 Solution Optimised Approach: using gp 
 - as the number which it will for in binary is gp

```csharp
Code here 
```

### 💡 Solution Optimised Approach:
 -using right shift 

```csharp
main logic code => (i<<x - 1)<<y
```
# what are the edge cases to look into 
- 

#  Question: can we get the bit value that is getting deropped by left shift or right shift

For a Right Shift (>>)

    Use the modulus operator: To find the least significant bit (LSB) that gets shifted out, you can use the modulus operator with 2 (number % 2). This gives you 1 if the LSB was 1 and 0 if it was 0. 

Perform the shift: Then, perform the right shift to move the bits to the right. 

For a Left Shift (<<) 

    1. Create a bitmask:
    Create a bitmask that has a 1 in the most significant bit (MSB) positions that will be shifted off. For example, if you have an 8-bit number and you shift left by 2, you'd create a mask of 11000000 in binary.
    2. Use the bitwise AND operator:
    Perform a bitwise AND operation between the original number and the bitmask (number & mask). This will isolate the bits that are about to be dropped.
    3. Perform the shift:
    Perform the left shift operation, which will discard the bits that are now known.

# Question : Give two binary stirng perform addition of binary string and return decimal number

### 💡 Solution Optimised Approach:
 -

```csharp
Code here 
```
#  Question: Given number A find the number x wihch results minimal output when we xor A^X = minimum

### 💡 Solution Optimised Approach:
 -

```csharp
Code here 
```

## Note: xor is way to count the number of exclusivity contribution of ones

