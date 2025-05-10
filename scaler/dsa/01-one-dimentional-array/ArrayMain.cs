using System;
using System.Collections.Generic;

class ArrayMain
{
    static void Main(string[] args)
    {
        // Test RainWaterTrapped
        var rainWater = new RainWaterTrapped();
        int[] heights = {0,1,0,2,1,0,1,3,2,1,2,1};
        Console.WriteLine("RainWaterTrapped: " + rainWater.Trap(heights));

        // Test MaxSumContiguousSubArray
        var maxSum = new Solution();
        List<int> list = new List<int> {-2, 1, -3, 4, -1, 2, 1, -5, 4};
        Console.WriteLine("MaxSumContiguousSubArray: " + maxSum.MaxSubArray(list));
    }
}
