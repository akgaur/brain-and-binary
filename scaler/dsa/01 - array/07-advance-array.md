# Advanced Array Problems & Solutions
---

## 1. Maximum Subarray Sum (Kadane's Algorithm)
- If all elements are positive: answer = sum of all.
- If all negative: answer = max element.
- Mixed: find contiguous segment with max sum.
- Brute force: O(N²) (all subarrays).
- Optimized: Kadane’s Algorithm (carry forward positive, reset if sum < 0).

**C# Code:**
```csharp
int MaxSubArray(int[] nums) {
    int max = nums[0], curr = nums[0];
    for (int i = 1; i < nums.Length; i++) {
        curr = Math.Max(nums[i], curr + nums[i]);
        max = Math.Max(max, curr);
    }
    return max;
}
// Time: O(n), Space: O(1)
```
---

## 2. Range Updates on Array (Suffix Update)
- Naive: loop through suffix every time (O(NQ)).
- Optimized: difference array, mark at start index, accumulate later.

**C# Code:**
```csharp
void UpdateSuffix(int[] arr, int idx, int val) {
    for (int i = idx; i < arr.Length; i++) arr[i] += val;
}
// Time: O(n), Space: O(1)
```
---

## 3. Range Updates on Array (L to R)
- Brute force: update all in range.
- Optimized: difference array trick (diff[L]+=val, diff[R+1]-=val).

**C# Code:**
```csharp
void RangeUpdate(int[] diff, int l, int r, int val) {
    diff[l] += val;
    if (r + 1 < diff.Length) diff[r + 1] -= val;
}
// Time: O(1), Space: O(1)
```
---

## 4. Rain Water Trapping
- Brute: for each i, find leftMax/rightMax (O(N²)).
- Optimized: precompute leftMax/rightMax arrays.
- Water at i = min(leftMax, rightMax) - height[i].

**C# Code:**
```csharp
int Trap(int[] h) {
    int n = h.Length, water = 0;
    int[] l = new int[n], r = new int[n];
    l[0] = h[0]; r[n - 1] = h[n - 1];
    for (int i = 1; i < n; i++) l[i] = Math.Max(l[i - 1], h[i]);
    for (int i = n - 2; i >= 0; i--) r[i] = Math.Max(r[i + 1], h[i]);
    for (int i = 0; i < n; i++) water += Math.Min(l[i], r[i]) - h[i];
    return water;
}
// Time: O(n), Space: O(n)
```
---

## 5. Submatrix Sum Query
- Brute: iterate inside every query (O(N²) per query).
- Optimized: precompute 2D prefix sum (O(1) per query).

**C# Code:**
```csharp
int SubMatrixSum(int[,] pref, int r1, int c1, int r2, int c2) {
    return pref[r2, c2]
        - (r1 > 0 ? pref[r1 - 1, c2] : 0)
        - (c1 > 0 ? pref[r2, c1 - 1] : 0)
        + (r1 > 0 && c1 > 0 ? pref[r1 - 1, c1 - 1] : 0);
}
// Time: O(1), Space: O(n*m)
```
---

## 6. Sum of All Submatrices
- Brute: enumerate all top-left/bottom-right corners (O(N⁴)).
- Optimized: contribution method, each element appears (i+1)(j+1)(N-i)(M-j) times.

**C# Code:**
```csharp
long SumAllSubMatrices(int[,] m) {
    int n = m.GetLength(0), mc = m.GetLength(1);
    long sum = 0;
    for (int i = 0; i < n; i++)
        for (int j = 0; j < mc; j++) {
            long ways = (i + 1) * (j + 1) * (n - i) * (mc - j);
            sum += m[i, j] * ways;
        }
    return sum;
}
// Time: O(n*m), Space: O(1)
```
---

## 7. Search in Row & Column Sorted Matrix
- Brute: check each element (O(NM)).
- Optimized: start from top-right, eliminate row/col each step (O(N+M)).

**C# Code:**
```csharp
bool SearchMatrix(int[,] mat, int target) {
    int r = 0, c = mat.GetLength(1) - 1;
    while (r < mat.GetLength(0) && c >= 0) {
        if (mat[r, c] == target) return true;
        if (mat[r, c] > target) c--;
        else r++;
    }
    return false;
}
// Time: O(n+m), Space: O(1)
```
---

## 8. Merge Intervals
- Brute: compare each interval with all others.
- Optimized: sort by start, merge overlapping on the fly.

**C# Code:**
```csharp
int[][] Merge(int[][] ivs) {
    Array.Sort(ivs, (a, b) => a[0].CompareTo(b[0]));
    var res = new List<int[]>();
    foreach (var iv in ivs) {
        if (res.Count == 0 || res[^1][1] < iv[0]) res.Add(iv);
        else res[^1][1] = Math.Max(res[^1][1], iv[1]);
    }
    return res.ToArray();
}
// Time: O(n log n), Space: O(n)
```
---

## 9. Insert Interval
- Insert new interval into sorted list, merge if overlap.

**C# Code:**
```csharp
int[][] Insert(int[][] ivs, int[] newI) {
    var res = new List<int[]>();
    foreach (var iv in ivs) {
        if (iv[1] < newI[0]) res.Add(iv);
        else if (newI[1] < iv[0]) { res.Add(newI); newI = iv; }
        else newI = new[] { Math.Min(iv[0], newI[0]), Math.Max(iv[1], newI[1]) };
    }
    res.Add(newI);
    return res.ToArray();
}
// Time: O(n), Space: O(n)
```
---

## 10. First Missing Positive
- Brute: HashSet check.
- Optimized: place each number in its correct index, first mismatch is answer.

**C# Code:**
```csharp
int FirstMissingPositive(int[] nums) {
    int n = nums.Length;
    for (int i = 0; i < n; i++) {
        while (nums[i] > 0 && nums[i] <= n && nums[nums[i] - 1] != nums[i]) {
            int tmp = nums[i];
            nums[i] = nums[tmp - 1];
            nums[tmp - 1] = tmp;
        }
    }
    for (int i = 0; i < n; i++) if (nums[i] != i + 1) return i + 1;
    return n + 1;
}
// Time: O(n), Space: O(1)
```
---

## 11. Minimum Absolute Difference of Any Pair
- Brute: all pairs (O(N²)).
- Optimized: sort, answer is min diff between consecutive elements.

**C# Code:**
```csharp
int MinAbsDiff(int[] nums) {
    Array.Sort(nums);
    int ans = int.MaxValue;
    for (int i = 1; i < nums.Length; i++)
        ans = Math.Min(ans, nums[i] - nums[i - 1]);
    return ans;
}
// Time: O(n log n), Space: O(1)
```