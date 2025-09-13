# 📘 Trees – Basic (Part 2)

---

## 📑 Table of Contents
1. Tree Traversals
   - Preorder
   - Inorder
   - Postorder
   - Iterative Traversals
2. Height of a Binary Tree
3. Search in a Binary Tree
4. Check Identical Trees
5. Check Mirror Trees

---

## 1. Tree Traversals

### Preorder Traversal (Root → Left → Right)
Traverse the root node first, then the left subtree, followed by the right subtree.

**C# Implementation:**
```csharp
void Preorder(TreeNode root)
{
    if (root == null) return;
    Console.Write(root.data + " ");
    Preorder(root.left);
    Preorder(root.right);
}
// Time Complexity: O(N)
// Space Complexity: O(N) due to recursion stack
```

### Inorder Traversal (Left → Root → Right)
Visit the left subtree, then the root node, and finally the right subtree.

**C# Implementation:**
```csharp
void Inorder(TreeNode root)
{
    if (root == null) return;
    Inorder(root.left);
    Console.Write(root.data + " ");
    Inorder(root.right);
}
// Time Complexity: O(N)
// Space Complexity: O(N)
```

### Postorder Traversal (Left → Right → Root)
Process the left subtree, then the right subtree, and finally the root node.

**C# Implementation:**
```csharp
void Postorder(TreeNode root)
{
    if (root == null) return;
    Postorder(root.left);
    Postorder(root.right);
    Console.Write(root.data + " ");
}
// Time Complexity: O(N)
// Space Complexity: O(N)
```

**Sample Outputs (for tree 1–7):**
- Inorder: `4 2 5 1 6 3 7`
- Preorder: `1 2 4 5 3 6 7`
- Postorder: `4 5 2 6 7 3 1`

### Iterative Traversals
Traversals can also be implemented using stack/queue instead of recursion. (See advanced section for code.)

---

## 2. Height of a Binary Tree
The height of a binary tree is the length of the longest path from the root to any leaf node.

**C# Implementation:**
```csharp
int Height(TreeNode root)
{
    if (root == null) return 0;
    int leftH = Height(root.left);
    int rightH = Height(root.right);
    return Math.Max(leftH, rightH) + 1;
}
// Time Complexity: O(N)
// Space Complexity: O(N)
```

---

## 3. Search in a Binary Tree
Check if a given value exists in the binary tree.

**C# Implementation:**
```csharp
bool Search(TreeNode root, int key)
{
    if (root == null) return false;
    if (root.data == key) return true;
    return Search(root.left, key) || Search(root.right, key);
}
// Time Complexity: O(N)
// Space Complexity: O(N)
```

---

## 4. Check Identical Trees
Two binary trees are identical if they have the same structure and node values.

**C# Implementation:**
```csharp
bool IsIdentical(TreeNode root1, TreeNode root2)
{
    if (root1 == null && root2 == null) return true;
    if (root1 == null || root2 == null) return false;
    if (root1.data != root2.data) return false;
    return IsIdentical(root1.left, root2.left) && IsIdentical(root1.right, root2.right);
}
// Time Complexity: O(N)
// Space Complexity: O(N)
```

---

## 5. Check Mirror Trees
Two binary trees are mirror images if their root nodes have equal values and the left subtree of one is the mirror of the right subtree of the other.

**C# Implementation:**
```csharp
bool IsMirror(TreeNode root1, TreeNode root2)
{
    if (root1 == null && root2 == null) return true;
    if (root1 == null || root2 == null) return false;
    if (root1.data != root2.data) return false;
    return IsMirror(root1.left, root2.right) && IsMirror(root1.right, root2.left);
}
// Time Complexity: O(N)
// Space Complexity: O(N)
```