/*
 * Question
 * Given two binary strings A and B. Return their sum (also a binary string).
 */

using System.Text;

public class AddBinaryStrings {
    public string AddBinary(string A, string B) {
        if (A.Length == 0 && B.Length == 0) {
            return "0";
        }
        StringBuilder result = new StringBuilder();

        int carrySum = 0;
        int i = A.Length - 1, j = B.Length - 1;
        while (i >= 0 || j >= 0 || carrySum == 1) {
            carrySum += (i >= 0) ? A[i] - '0' : 0;
            carrySum += (j >= 0) ? B[j] - '0' : 0;

            result.Append((char)(carrySum % 2 + '0'));
            carrySum /= 2;
            i--; j--;
        }
        int start = result.Length - 1;
        while (start >= 0 && result[start] == '0') {
            start--;
        }
        if (start != result.Length - 1) {
            result.Remove(start + 1, result.Length - (start + 1));
        }

        var arr = result.ToString().ToCharArray();
        System.Array.Reverse(arr);
        return new string(arr);
    }
}