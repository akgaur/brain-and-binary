using System;
using System.Collections.Generic;

namespace Dsa
{
    class Program
    {
        static void Main(string[] args)
        {
            // One Dimensional Array Demos
            Console.WriteLine("== One Dimensional Array Demos ==");
            var rainWater = new RainWaterTrapped();
            int[] heights = {0,1,0,2,1,0,1,3,2,1,2,1};
            Console.WriteLine("RainWaterTrapped: " + rainWater.Trap(heights));

            var maxSum = new MaxSumContiguousSubArray();
            List<int> list = new List<int> {-2, 1, -3, 4, -1, 2, 1, -5, 4};
            Console.WriteLine("MaxSumContiguousSubArray: " + maxSum.MaxSubArray(list));

            // Bit Manipulation Demos
            Console.WriteLine("\n== Bit Manipulation Demos ==");
            var singleNumber = new SingleNumber();
            int[] arr = {2, 3, 2, 4, 4};
            Console.WriteLine("SingleNumber: " + singleNumber.singleNumber(arr));

            var addBinary = new AddBinaryStrings();
            string A = "1010", B = "1011";
            Console.WriteLine("AddBinaryStrings: " + addBinary.AddBinary(A, B));

            var numBits = new NumberOfSetBits();
            int num = 11; // binary 1011
            Console.WriteLine("NumberOf1Bit: " + numBits.GetNumberOfSetBit(num));
        }
    }
}