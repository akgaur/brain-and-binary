/*
 *Question
 *Write a function that takes an integer and returns the number of 1 bits present in its binary representation.
*/

public class NumberOfSetBits
{
    public int GetNumberOfSetBit(int A) {
        int count = 0;
        while (A != 0) {
            count += (A & 1);
            A = A >> 1;
        }
        return count;
    }
}
