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

### 🔹 Preorder (Root → Left → Right)
**C# Code:**
```csharp
void Preorder(TreeNode root)
{
    if (root == null) return;
    Console.Write(root.data + " ");
    Preorder(root.left);
    Preorder(root.right);
}
// Time: O(N), Space: O(N) (recursion stack)
```

### 🔹 Inorder (Left → Root → Right)
**C# Code:**
```csharp
void Inorder(TreeNode root)
{
    if (root == null) return;
    Inorder(root.left);
    Console.Write(root.data + " ");
    Inorder(root.right);
}
// Time: O(N), Space: O(N)
```

### 🔹 Postorder (Left → Right → Root)
**C# Code:**
```csharp
void Postorder(TreeNode root)
{
    if (root == null) return;
    Postorder(root.left);
    Postorder(root.right);
    Console.Write(root.data + " ");
}
// Time: O(N), Space: O(N)
```

**Example Output (for tree 1–7):**
- Inorder: `4 2 5 1 6 3 7`
- Preorder: `1 2 4 5 3 6 7`
- Postorder: `4 5 2 6 7 3 1`

### 🔹 Iterative Traversals
Traversals can also be implemented using stack/queue instead of recursion. (See advanced section for code.)

---

## 2. Height of a Binary Tree
**Definition:** Height = length of the longest path from root to any leaf node.

**C# Code:**
```csharp
int Height(TreeNode root)
{
    if (root == null) return 0;
    int leftH = Height(root.left);
    int rightH = Height(root.right);
    return Math.Max(leftH, rightH) + 1;
}
// Time: O(N), Space: O(N)
```

---

## 3. Search in a Binary Tree
**Problem:** Given a value n, check if it exists in the tree.

**C# Code:**
```csharp
bool Search(TreeNode root, int key)
{
    if (root == null) return false;
    if (root.data == key) return true;
    return Search(root.left, key) || Search(root.right, key);
}
// Time: O(N), Space: O(N)
```

---

## 4. Check Identical Trees
**Definition:** Two binary trees are identical if they have the same structure and node values.

**C# Code:**
```csharp
bool IsIdentical(TreeNode root1, TreeNode root2)
{
    if (root1 == null && root2 == null) return true;
    if (root1 == null || root2 == null) return false;
    if (root1.data != root2.data) return false;
    return IsIdentical(root1.left, root2.left) && IsIdentical(root1.right, root2.right);
}
// Time: O(N), Space: O(N)
```

---

## 5. Check Mirror Trees
**Definition:** Two binary trees are mirror images if root nodes have equal values and left subtree of one is mirror of right subtree of the other.

**C# Code:**
```csharp
bool IsMirror(TreeNode root1, TreeNode root2)
{
    if (root1 == null && root2 == null) return true;
    if (root1 == null || root2 == null) return false;
    if (root1.data != root2.data) return false;
    return IsMirror(root1.left, root2.right) && IsMirror(root1.right, root2.left);
}
// Time: O(N), Space: O(N)
```