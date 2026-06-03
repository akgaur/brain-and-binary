/*
 * Question
 * Given two binary strings A and B. Return their sum (also a binary string).
 */


public class AddBinaryStrings {
    public String addBinary(String A, String B) {
        if(A.length() == 0 && B.length() == 0){
            return "0";
        }
        StringBuilder result = new StringBuilder();

        int carrySum = 0;
        int i = A.length() -1; int j = B.length() -1; 
        while(i >=0 || j>=0 || carrySum ==1){
            
            carrySum += ((i >=0)? A.charAt(i) - '0' : 0);
            carrySum += ((j >=0)? B.charAt(j) - '0': 0);

            result.append((char)(carrySum%2 + '0'));
            carrySum /= 2;
             i--; j--;
        }
        int start = result.length()-1;
        while(start >=0 && result.charAt(start) == '0') {
            start--;
        }
        if(start != result.length()-1) {
            result.delete(start+1,result.length());
        }

        return result.reverse().toString();
    }
}