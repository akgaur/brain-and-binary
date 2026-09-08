# Trees: Introduction & Key Concepts

## 🌳 What is a Tree?
- A hierarchical data structure with nodes connected by edges.
- Root node at the top; leaves at the bottom.
- No cycles; each child has one parent.

## 🔑 Key Concepts
- **Binary Tree**: Each node has at most two children.
- **BST (Binary Search Tree)**: Left < Root < Right.
- **Traversal**: Inorder, Preorder, Postorder.
- **Height/Depth**: Distance from root to leaf.
- **Balanced Trees**: AVL, Red-Black, etc.

## 💡 MAANG Interview Approaches
- Recursive and iterative traversals.
- Finding height, diameter, LCA (Lowest Common Ancestor).
- Serialization/Deserialization.
- Tree construction from traversals.
- Practice edge cases: empty tree, single node, skewed tree.


# **📘 Trees Basics**

## **📑 Table of Contents**

2. Introduction to Trees
3. Binary Tree
4. Tree Terminology
5. Tree Traversals
---
   
## **2\. Introduction to Trees**

* A **Tree** is a **non-linear hierarchical data structure**.
* Different from **Arrays, Linked Lists, Stacks, and Queues** which are **linear**.

**Analogy (HTML Document Structure):**

22. `<HTML>`  
23.    `<HEAD> … </HEAD>`  
24.    `<BODY> … </BODY>`  
25. `</HTML>`  
      
    ---

## **3\. Binary Tree**

* Each node can have **at most 2 children**:

  * **Left child**
  * **Right child**

**Node Structure:**

26. `class TreeNode {`  
27.     `int data;`  
28.     `TreeNode left, right;`  
29.   
30.     `TreeNode(int data) {`  
31.         `this.data = data;`  
32.         `left = right = null;`  
33.     `}`  
34. `}`  
    

**Example Creation:**

35. `TreeNode root = new TreeNode(10);`  
36. `root.left = new TreeNode(12);`  
37. `root.right = new TreeNode(15);`  
38. `root.right.left = new TreeNode(16);`  
      
    ---

## **4\. Tree Terminology**

* **Root** → The topmost node.
* **Child** → A node directly under another node.
* **Parent** → A node that has children.
* **Subtree** → A tree formed by any node and its descendants.
* **Forest** → A collection of disjoint trees.

  ---

  ## **5\. Tree Traversals**

### Preorder (Root → Left → Right)
Example Output: `1 2 4 5 3 6 7`

**C# Code:**
```csharp
void Preorder(TreeNode node)
{
    if (node == null) return;
    Console.Write(node.data + " ");
    Preorder(node.left);
    Preorder(node.right);
}
```

### Inorder (Left → Root → Right)
Example Output: `4 2 5 1 6 3 7`

**C# Code:**
```csharp
void Inorder(TreeNode node)
{
    if (node == null) return;
    Inorder(node.left);
    Console.Write(node.data + " ");
    Inorder(node.right);
}
```

### Postorder (Left → Right → Root)
Example Output: `4 5 2 6 7 3 1`

**C# Code:**
```csharp
void Postorder(TreeNode node)
{
    if (node == null) return;
    Postorder(node.left);
    Postorder(node.right);
    Console.Write(node.data + " ");
}
```


