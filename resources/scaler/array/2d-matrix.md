# 🧠 Basic Topics in 2D Matrix

## 1. 📘 Definition & Structure
- What is a matrix?
- Rows and columns
- Notation: `matrix[i][j]`
- Square vs. rectangular matrix

---

## 2. 🧾 Matrix Declaration & Initialization
- Static declaration (e.g., `int[,] matrix = new int[3,3];`)
- Initialization with values
- Input from user or file

---

## 3. 🔁 Matrix Traversal
- Iterating through all matrix elements using nested `for` loops
- Row-wise traversal
```csharp
for (int i = 0; i < rows; i++)
    for (int j = 0; j < cols; j++)
        Console.Write(matrix[i, j] + " ");
```
- Column-wise traversal
```csharp
for (int j = 0; j < cols; j++)
    for (int i = 0; i < rows; i++)
        Console.Write(matrix[i, j] + " ");
```
		
---

## 4. 🔺 Main Diagonal
- Elements where `i == j`
- Only valid in square matrices
```csharp
for (int i = 0; i < n; i++)
    Console.Write(matrix[i, i] + " ");
```
---

## 5. 🔻 Reverse Diagonal (Anti-Diagonal)
- Elements where `i + j == n - 1`
- Also valid only in square matrices
```csharp
for (int i = 0; i < n; i++)
    Console.Write(matrix[i, n - 1 - i] + " ");
	```
---

## 6. 🔁 Transpose of a Matrix
- Convert rows to columns and vice versa
- `transpose[i][j] = original[j][i]`
```csharp
int[,] transpose = new int[cols, rows];
for (int i = 0; i < rows; i++)
    for (int j = 0; j < cols; j++)
        transpose[j, i] = matrix[i, j];
```
---

## 7. ➕ Matrix Addition and Subtraction
- Add or subtract corresponding elements
- Matrices must be of the same size
```csharp
int[,] result = new int[rows, cols];
for (int i = 0; i < rows; i++)
    for (int j = 0; j < cols; j++)
        result[i, j] = matrix1[i, j] + matrix2[i, j];  // or use '-' for subtraction
```

---

## 8. ✖️ Matrix Multiplication
- Multiply rows of first with columns of second
- Rules: `A (m x n)` * `B (n x p)` = `Result (m x p)`
```csharp
int[,] result = new int[m, p];
for (int i = 0; i < m; i++)
    for (int j = 0; j < p; j++)
        for (int k = 0; k < n; k++)
            result[i, j] += A[i, k] * B[k, j];
```

---

## 9. 📦 Identity Matrix
- Square matrix with 1s on the main diagonal, 0s elsewhere
```csharp
for (int i = 0; i < n; i++)
    for (int j = 0; j < n; j++)
        identity[i, j] = (i == j) ? 1 : 0;
```

---

## 10. 🔁 Rotating a Matrix
- Rotate 90°, 180°, 270°
- Often used in image processing, puzzles
```csharp
for (int i = 0; i < n; i++)
    for (int j = i; j < n; j++)
        (matrix[i, j], matrix[j, i]) = (matrix[j, i], matrix[i, j]); // transpose

for (int i = 0; i < n; i++)
    Array.Reverse(matrix, i * n, n); // reverse each row
```

---

## 11. 🌀 Spiral Traversal
- Print elements in spiral order from outer layer to inner
```csharp
int top = 0, bottom = rows - 1, left = 0, right = cols - 1;
while (top <= bottom && left <= right)
{
    for (int i = left; i <= right; i++) Console.Write(matrix[top, i] + " ");
    top++;
    for (int i = top; i <= bottom; i++) Console.Write(matrix[i, right] + " ");
    right--;
    if (top <= bottom)
    {
        for (int i = right; i >= left; i--) Console.Write(matrix[bottom, i] + " ");
        bottom--;
    }
    if (left <= right)
    {
        for (int i = bottom; i >= top; i--) Console.Write(matrix[i, left] + " ");
        left++;
    }
}
```

---

## 12. ⏫ Upper and Lower Triangular Matrix
- **Upper Triangular**: All elements below the main diagonal are 0
```csharp
for (int i = 0; i < n; i++)
    for (int j = 0; j < n; j++)
        Console.Write(i <= j ? matrix[i, j] + " " : "0 ");
```

- **Lower Triangular**: All elements above the main diagonal are 0
```csharp
for (int i = 0; i < n; i++)
    for (int j = 0; j < n; j++)
        Console.Write(i >= j ? matrix[i, j] + " " : "0 ");
```

---

## 📌 Summary

| Concept               | Description                               |
|------------------------|-------------------------------------------|
| Matrix Notation        | `matrix[i][j]` for row `i`, column `j`    |
| Main Diagonal          | Elements where `i == j`                   |
| Reverse Diagonal       | Elements where `i + j == n - 1`           |
| Transpose              | Flip across the main diagonal             |
| Rotation               | Clockwise/anti-clockwise transformation   |
| Matrix Multiplication  | Combine two matrices by dot product       |

