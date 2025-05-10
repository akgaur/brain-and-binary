/*Question
 *Given a vector A of non-negative integers representing an elevation map where the width of each bar is 1, compute how much water it is able to trap after raining.
*/

public class RainWaterTrapped {
    public int Trap(int[] A) {
        int N = A.Length;
        int[] maxL = new int[N];
        int[] maxR = new int[N];

        maxL[0] = A[0];
        for (int i = 1; i < N; i++) {
            maxL[i] = (A[i] > maxL[i - 1]) ? A[i] : maxL[i - 1];
        }

        maxR[N - 1] = A[N - 1];
        for (int i = N - 2; i >= 0; i--) {
            maxR[i] = (A[i] > maxR[i + 1]) ? A[i] : maxR[i + 1];
        }

        int waterTrapped = 0;
        for (int i = 1; i < N - 1; i++) {
            int bhd = System.Math.Min(maxL[i], maxR[i]);
            if (A[i] < bhd) {
                waterTrapped += (bhd - A[i]);
            }
        }
        return waterTrapped;
    }
}
