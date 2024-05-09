/*
Runtime 407 ms Beats 87.27% of users with C#
Memory 70.14 MB Beats 92.73% of users with C#
*/

public class Solution {
    public long MaximumHappinessSum(int[] happiness, int k) {
        Array.Sort(happiness);
        long best = 0, taken = 0;
        for (int i=happiness.Length-1; i>=happiness.Length-k; --i) {
            best += Math.Max(happiness[i] - taken, 0);
            taken++;
        }
        
        return best;
    }
}
