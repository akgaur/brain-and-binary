/*
Question
  Given an array of integers A, every element appears twice except for one. 
  Find that integer that occurs once.
Approch 
   //  a ^ a = 0; a ^ a ^ a = a;  a ^ b ^ a = b; 
   // with xor operator we can find if a number exists odd number of times in an Array of number
*/

public class SingleNumber {

    public int singleNumber(final int[] A) {
        
        int ans = A[0];
        for(int i=1; i<A.length; i++){
            ans = ans ^ A[i];
        }
        return ans;
    }
}
