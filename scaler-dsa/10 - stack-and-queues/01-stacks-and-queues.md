# Stacks and Queues: Data Structures & Interview Concepts

---

## Definition
- **Stack**: A linear data structure that follows the Last In First Out (LIFO) principle. Elements are added (push) and removed (pop) from the same end, called the top.
- **Queue**: A linear data structure that follows the First In First Out (FIFO) principle. Elements are added (enqueue) at the rear and removed (dequeue) from the front.

---

## Key Concepts
### Stack
- Array or Linked List implementation.
- **Peek/Top**: View last element.
- **Size/Empty**: Check status.

### Queue
- Array or Linked List implementation.
- **Circular Queue**: Wraps around for efficient use of space.
- **Priority Queue**: Elements with priority.

---

## MAANG Interview Approaches
### Stack
- Parentheses matching, next greater element.
- Undo/redo, backtracking, DFS.
- Edge cases: empty stack, overflow.

### Queue
- Level order traversal (BFS), sliding window problems.
- Producer-consumer, scheduling.
- Edge cases: empty queue, overflow, underflow.

---

# Stacks and Queues Basics

---

## Stack (Abstract Data Structure)
- **LIFO (Last In First Out)**
- **Operations:**
  - `push(x)` → Insert element on top.
  - `pop()` → Remove element from top.
  - `peek()` → Return topmost element without removing.
  - `isEmpty()` → Check if stack is empty.

**Applications:**
- Undo/Redo operations.
- Back/Forward button in browser.
- Function call stack.
- Printer job scheduling (last printed job comes out last).

---

## Queue (Abstract Data Structure)
- **FIFO (First In First Out)**
- **Operations:**
  - `enqueue(x)` → Insert element at rear.
  - `dequeue()` → Remove element from front.

**Applications:**
- Message queues (Kafka, RabbitMQ, ActiveMQ).
- CPU scheduling.
- Print job scheduling.

---

## Stack Implementations

### Using Array
```csharp
int[] stack = new int[SIZE];
int top = -1;

void push(int x) {
    if (top == SIZE-1) { /* overflow */ }
    stack[++top] = x;
}

int pop() {
    if (top == -1) { /* underflow */ }
    return stack[top--];
}

int peek() {
    return stack[top];
}
```

### Using Linked List
- **Push:** Insert at front.
- **Pop:** Remove from front.
```csharp
void push(int x) {
    Node newNode = new Node(x);
    newNode.next = head;
    head = newNode;
}

int pop() {
    if (head == null) { /* underflow */ }
    int val = head.data;
    head = head.next;
    return val;
}
```

---

## Queue Implementations

### Using Array
- Enqueue at rear.
- Dequeue from front.
- Requires shifting elements left after dequeue (inefficient).

### Using Linked List
- Maintain `front` and `rear`.
- Enqueue at rear, dequeue from front.
```csharp
void enqueue(int x) {
    Node newNode = new Node(x);
    if (rear == null) {
        front = rear = newNode;
        return;
    }
    rear.next = newNode;
    rear = newNode;
}

int dequeue() {
    if (front == null) { /* underflow */ }
    int val = front.data;
    front = front.next;
    if (front == null) rear = null;
    return val;
}
```

---

## Special Stack Problem: Min Stack

**Requirement:** Implement a stack that supports:
- `push(x)` → Insert element
- `pop()` → Remove top element
- `getMin()` → Return the minimum element currently in stack in O(1)

**Approach:**
- Maintain two stacks:
  - Main Stack: Stores actual values
  - Min Stack: Stores current minimum values

**Logic:**
- On `push(x)`: Insert into main stack. If minStack is empty or x <= minStack.peek(), also push into minStack.
- On `pop()`: Remove from main stack. If popped element == minStack.peek(), pop from minStack too.
- On `getMin()`: Return minStack.peek().

**C# Code Example:**
```csharp
Stack<int> st = new Stack<int>();
Stack<int> minSt = new Stack<int>();

void push(int x) {
    st.Push(x);
    if (minSt.Count == 0 || x <= minSt.Peek())
        minSt.Push(x);
}

int pop() {
    int element = st.Pop();
    if (element == minSt.Peek())
        minSt.Pop();
    return element;
}

int getMin() {
    return minSt.Peek();
}
```


