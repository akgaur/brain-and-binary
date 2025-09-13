# Linked Lists: Introduction & Key Concepts

## Overview
A linked list is a linear data structure where each node points to the next node. It supports dynamic size and efficient insert/delete operations compared to arrays.

---

## MAANG Interview Approaches
- Reversal, cycle detection (Floyd's algorithm).
- Merge, split, find middle, remove nth node.
- Edge cases: empty list, single node, cycles.

---

# Working of ArrayList

## 🔹 Introduction
- An **ArrayList** is a **resizable array implementation** of the `List` interface.  
- Unlike arrays, it can **grow and shrink dynamically**.  
- Provides **random access** like arrays, but with flexible size management.

---

## 🔹 Internal Working
1. **Backed by Array**  
   - Internally uses a **dynamic array**.  
   - When created, it has a **default capacity** (e.g., 10 in Java).  

2. **Adding Elements**  
   - Elements are stored in the internal array.  
   - If array is **not full**, element is placed at the next index.  
   - If array is **full**, a **new larger array** is created (usually 1.5x or 2x bigger), and old elements are copied.

3. **Accessing Elements**  
   - Provides **O(1)** time complexity for random access using index.  

4. **Resizing Mechanism**  
   - Old array elements are copied into a new, larger array.  
   - This resizing makes occasional insertions costly (O(N)), but **amortized time is O(1)**.

---

## Arrays vs Linked List

**Arrays**
- Contiguous memory allocation.
- Direct/random access using index.
- Size must be predefined.
- Resizing is costly (copying elements).

**Linked List**
- Non-contiguous memory allocation.
- Nodes connected via pointers.
- No need for predefined size.
- Efficient insertion/deletion.
- Random access is inefficient (O(N)).

---

## Types of Linked List
- **Singly Linked List**: Each node points to next only.
- **Doubly Linked List**: Each node has prev and next pointers.
- **Circular Linked List**: Last node points back to head.
- **Skip List**: Multi-level list for faster search.

---

## Node Structure
A linked list is made of nodes, each having:
- Data
- Pointer/reference to the next node

**C# Example:**
```csharp
public class Node
{
    public int data;
    public Node next;
    public Node(int val) { data = val; next = null; }
}
```

---

## Operations on Linked List

### 1. Find Length of Linked List, given input is haad of LL.
Traverse the list and count nodes.

**C# Code:**
```csharp
public int GetLength(Node head)
{
    int len = 0;
    Node temp = head;
    while (temp != null)
    {
        len++;
        temp = temp.next;
    }
    return len;
}
// Time: O(N), Space: O(1)
```

---

### 2. Insert at Front, given input is haad of LL.
Create a new node, point its next to current head, update head.

**C# Code:**
```csharp
public Node InsertFront(Node head, int val)
{
    Node newNode = new Node(val);
    newNode.next = head;
    return newNode;
}
// Time: O(1), Space: O(1)
```

---

### 3. Insert at End, given input is haad of LL.
Traverse to last node, add new node at the end.

**C# Code:**
```csharp
public Node InsertEnd(Node head, int val)
{
    Node newNode = new Node(val);
    if (head == null) return newNode;
    Node temp = head;
    while (temp.next != null)
        temp = temp.next;
    temp.next = newNode;
    return head;
}
// Time: O(N), Space: O(1)
```

**Alternative (using Tail pointer):**
```csharp
public Node InsertEndWithTail(Node tail, int val)
{
    Node newNode = new Node(val);
    tail.next = newNode;
    return newNode;
}
// Time: O(1), Space: O(1)
```

---

### 4. Insert at Given Position, given input is haad of LL and pos k.
Traverse to node before position, adjust pointers.

**C# Code:**
```csharp
public Node InsertAtPosition(Node head, int pos, int val)
{
    if (pos == 1) return InsertFront(head, val);
    Node newNode = new Node(val);
    Node temp = head;
    for (int i = 1; i < pos - 1 && temp != null; i++)
        temp = temp.next;
    if (temp == null) return head; // position out of bounds
    newNode.next = temp.next;
    temp.next = newNode;
    return head;
}
// Time: O(pos), Space: O(1)
```

---

### 5. Delete from Beginning
Move head to next node.

**C# Code:**
```csharp
public Node DeleteFront(Node head)
{
    if (head == null) return null;
    return head.next;
}
// Time: O(1), Space: O(1)
```

---

### 6. Delete from End
Traverse to second last node, set its next to null.

**C# Code:**
```csharp
public Node DeleteEnd(Node head)
{
    if (head == null || head.next == null) return null;
    Node temp = head;
    while (temp.next.next != null)
        temp = temp.next;
    temp.next = null;
    return head;
}
// Time: O(N), Space: O(1)
```

## Complexity Overview
- **Access (Random):** O(N)
- **Insert/Delete (Front, End, Middle):** O(1) if position is known, otherwise O(N)

