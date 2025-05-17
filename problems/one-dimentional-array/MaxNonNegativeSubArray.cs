namespace BrainAndBinary.problems.one_dimentional_array
{
    public class MaxNonNegativeSubArray
    {
        public void TestMaxNonNegativeSubArray()
        {
            var testCases = new List<List<int>> {
                new List<int>{1, 2, 3},
                new List<int>{-1, -2, -3},
                new List<int>{-1, 0, -2},
                new List<int>{0, 0, 0, 0},
                new List<int>{1, 2, 5, -7, 2, 3},
                new List<int>{1, 2, -1, 0, 0, 3},
                new List<int>{5, 1, -1, 3, 3},
                new List<int>{int.MaxValue, int.MaxValue, -1, int.MaxValue},
                new List<int>{1, 2, 3, -5},
                new List<int>{-10, 1, 2, 3},
                new List<int>{-1, -2, 0, -3},
                new List<int>{7},
                new List<int>{-5},
                new List<int>{1, 2, -1, 1, 2}
            };
            foreach (var testCase in testCases)
            {
                var result = MaxSet(testCase);
                Console.WriteLine("Input: " + string.Join(",", testCase));
                Console.WriteLine("Output: " + string.Join(",", result));
                Console.WriteLine();
            }
        }
        public List<int> MaxSet(List<int> A)
        {
            List<int> result = new List<int>();
            long maxSum = -1;
            long currentSum = 0;

            int start = -1, end = -1;
            int s = 0;

            for (int i = 0; i < A.Count; i++)
            {
                if (A[i] >= 0)
                {
                    currentSum += A[i];

                    if (currentSum > maxSum ||
                        (currentSum == maxSum && (i - s > end - start)))// ||
                        //(currentSum == maxSum && (i - s == end - start) && s < start)) //Optinal condition //Check reason below
                    {
                        maxSum = currentSum;
                        start = s;
                        end = i;
                    }
                }
                else
                {
                    currentSum = 0;
                    s = i + 1;
                }
                //Console.WriteLine($"MaxSum:{maxSum}, CurrentSum:{currentSum}, Start:{start}, End:{end}, S:{s}, E:{i}");
            }

            if (start != -1 && end != -1)
            {
                for (int i = start; i <= end; i++)
                {
                    result.Add(A[i]);
                }
            }

            return result;
        }

        // Note on why we do NOT need the following condition:
        // (currentSum == maxSum && (i - s == end - start) && s < start)
        //
        // Explanation:
        // - We only update maxSum, start, and end when:
        //     1. currentSum > maxSum  => strictly better sum
        //     2. currentSum == maxSum && (i - s > end - start) => same sum but longer subarray
        //
        // - In the case where a new subarray has the same sum and the same length,
        //   we do NOT update anything. This means the first such subarray encountered
        //   will be retained, which satisfies the problem requirement to return the
        //   earliest subarray in case of a tie.
        //
        // - Therefore, the third condition for equal sum, equal length, and earlier start
        //   is not necessary — because the earlier subarray is naturally preserved
        //   by not updating on equal values.

    }
}
