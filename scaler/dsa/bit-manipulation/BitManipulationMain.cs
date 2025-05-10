using System;

class BitManipulationMain
{
    static void Main(string[] args)
    {
        // Test SingleNumber
        var singleNumber = new SingleNumber();
        int[] arr = {2, 3, 2, 4, 4};
        Console.WriteLine("SingleNumber: " + singleNumber.singleNumber(arr));

        // Test AddBinaryStrings
        var addBinary = new AddBinaryStrings();
        string A = "1010", B = "1011";
        Console.WriteLine("AddBinaryStrings: " + addBinary.AddBinary(A, B));

        // Test NumberOf1Bit
        var numBits = new Solution();
        int num = 11; // binary 1011
        Console.WriteLine("NumberOf1Bit: " + numBits.NumSetBits(num));
    }
}
