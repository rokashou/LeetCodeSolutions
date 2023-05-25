/*
May 25, 2023 21:57
Runtime 29 ms Beats 100%
Memory 29.2 MB Beats 100%
*/

public class Solution {
    public double New21Game(int n, int k, int maxPts) {
        var dp = new double[n + 1];
        dp[0] = 1;
        double s = k > 0 ? 1 : 0;
        for(int i = 1; i <= n; i++)
        {
            dp[i] = s / maxPts;
            if (i < k)
                s += dp[i];
            if (i - maxPts >= 0 && i - maxPts < k)
                s -= dp[i - maxPts];
        }

        double ans = 0;
        for (int i = k; i <= n; i++)
        {
            ans += dp[i];
        }
        return ans;        
    }
}
