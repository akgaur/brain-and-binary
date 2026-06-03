/*
 *Question
 *Write a function that takes an integer and returns the number of 1 bits present in its binary representation.
*/

class Solution {
    public int numSetBits(int A) {
        int count =0;
        while(A>0){
            count += A%2;
            A= A/2;
        }

        return count;
    }
}
