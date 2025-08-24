  String Handling Guide

# String Handling in Programming Languages

Comprehensive guide to string manipulation, mutability, and algorithms

## 🔤 String Basics

*   A string is an array of characters
*   Strings are typically immutable in many programming languages
*   Different languages handle strings differently in terms of mutability

## 🔄 String Mutability in Different Languages

#### Java

*   **Immutable**: String class creates immutable strings
*   **Mutable alternatives**: StringBuilder (not thread-safe), StringBuffer (thread-safe)

#### C#

*   **Immutable**: string creates immutable strings
*   **Mutable alternative**: StringBuilder

#### Python

*   **Immutable**: str objects are immutable
*   **Mutable alternatives**: bytearray, list of characters, or string concatenation with join()

#### JavaScript

*   **Immutable**: Strings are immutable
*   **Mutable alternatives**: Convert to array, manipulate, then join back to string

#### Go

*   **Immutable**: Strings are immutable byte slices
*   **Mutable alternatives**: \[\]byte (byte slice) or strings.Builder

## 🔢 ASCII Character Table

### Character Ranges

*   **Uppercase letters**: A-Z (ASCII 65-90)
*   **Lowercase letters**: a-z (ASCII 97-122)
*   **Digits**: 0-9 (ASCII 48-57)

### Easy Memory Tricks

*   **'A'** = 65, **'a'** = 97 (difference of 32 between cases)
*   **'0'** = 48
*   To convert lowercase to uppercase: subtract 32
*   To convert uppercase to lowercase: add 32

## 🏊 String Pool & Immutability

### String Pool Concept

*   String pool is a special memory region where string literals are stored
*   Reusing identical strings saves memory
*   Example: In Java, `String s1 = "hello"; String s2 = "hello";` - both reference same object

### Why Immutability?

*   **Security**: Prevents unauthorized modification (e.g., database connections, file paths)
*   **Thread Safety**: Immutable objects are inherently thread-safe
*   **HashCode Caching**: Hash codes can be cached since content never changes
*   **String Pool Optimization**: Enables string interning and reuse

## ❓ Question 1: Sort String in Ascending Order of Characters

**Problem**: Given a string, return it sorted in ascending order of characters

**Hint**: Use counting sort (best approach for character sorting)

### Approach:

1.  Count frequency of each character
2.  Reconstruct string from sorted character counts

### Solution:

```
public static string SortString(string s)
{
    int[] count = new int[256];
    foreach (char c in s) count[c]++;
    
    var result = new char[s.Length];
    int index = 0;
    for (int i = 0; i < 256; i++)
        for (int j = 0; j < count[i]; j++)
            result[index++] = (char)i;
    
    return new string(result);
}
```

## ❓ Question 2: Reverse Words in a String

**Problem**: Reverse the string word by word without leading/trailing spaces and with single spaces between words

### Approach:

1.  Reverse the entire string
2.  Reverse each word individually
3.  Handle spaces appropriately

### Solution:

```
public static string ReverseWords(string s)
{
    // Trim and split manually
    List<string> words = new List<string>();
    int start = -1;
    
    for (int i = 0; i < s.Length; i++)
    {
        if (s[i] != ' ')
        {
            if (start == -1) start = i;
        }
        else if (start != -1)
        {
            words.Add(s.Substring(start, i - start));
            start = -1;
        }
    }
    if (start != -1) words.Add(s.Substring(start, s.Length - start));
    
    // Reverse words
    for (int i = 0, j = words.Count - 1; i < j; i++, j--)
    {
        string temp = words[i];
        words[i] = words[j];
        words[j] = temp;
    }
    
    // Join words
    if (words.Count == 0) return "";
    
    string result = words[0];
    for (int i = 1; i < words.Count; i++)
        result += " " + words[i];
    
    return result;
}
```

## 💡 Key Takeaways

*   **Strings are fundamental** data structures in all programming languages
*   **Immutability provides benefits** for security, threading, and optimization
*   **Language-specific mutable alternatives** exist for performance-critical operations
*   **ASCII knowledge is crucial** for character manipulation tasks
*   **Efficient string algorithms** often use techniques like counting sort and two-pointer reversal