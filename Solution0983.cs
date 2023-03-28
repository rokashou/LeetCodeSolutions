/*
Mar 28, 2023 21:27
Runtime 80 ms, Beats 92.31%
Memory 38.3 MB, Beats 80%
*/

public class Solution {
    private int[] days, costs;
    private int?[] memo;
    private int[] durations = new int[] { 1, 7, 30 };

    public int MincostTickets(int[] days, int[] costs)
    {
        this.days = days;
        this.costs = costs;
        memo = new int?[days.Length];

        return dp(0);
    }

    private int dp(int i)
    {
        if (i >= days.Length)
            return 0;
        if(memo[i] != null)
            return memo[i].Value;

        int ans = int.MaxValue;
        int j = i;
        for (int k = 0; k < 3; ++k)
        {
            while (j < days.Length && days[j] < days[i] + durations[k])
                j++;
            ans = Math.Min(ans, dp(j) + costs[k]);
        }

        memo[i] = ans;
        return ans;
    }
}
