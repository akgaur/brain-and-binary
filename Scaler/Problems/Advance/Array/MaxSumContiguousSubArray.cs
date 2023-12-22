
/*Question
 *Find the maximum sum of contiguous non-empty subarray within an array A of length N.
*/

class Solution {
    public int maxSubArray(List<int> A) {
      int arrLen = A.Count();
      int[] result = new int[arrLen]; 
      int max = A[0];
      result[0] = A[0];
      
      for(int i=1; i<arrLen; i++){
          result[i] = (result[i-1] + A[i]) > A[i] ? (result[i-1] + A[i]) : A[i];
      }

      for(int i=0; i<arrLen; i++){
          if(result[i]>max){
              max = result[i];
          }
      }

      return max;
    }
}
