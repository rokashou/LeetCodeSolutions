/*
May 22, 2023 21:45
Runtime 21 ms Beats 84.78%
Memory 26.7 MB Beats 34.78%
*/
public class Solution {
    public int NumTrees(int n) {
        if (n == 0 || n == 1)
        {
            return 1;
        }
        int[] dp = new int[n +1];
        dp[0] = dp[1] = 1;
        for (int nn = 2; nn < n + 1; nn++) {
            for (int m = 1; m < nn + 1; m++) {
                dp[nn] += dp[m - 1] * dp[nn - m];
            }
        
        }
        return dp[n];
    }
}



/*
Approach 2: Catalan Number
May 22, 2023 21:45
Runtime 26 ms Beats 56.52%
Memory 26.7 MB Beats 34.78%
*/

public class Solution {
    private long CalculateCoeff(int n, int k)
    {
        long res = 1;
        if (k > n - k) k = n - k;
        for (int i = 0; i < k; i++)
        {
            res *= (n - i);
            res /= (i + 1);
        }
        return res;
    }

    public int NumTrees(int n)
    {
        return (int)(CalculateCoeff(2*n,n)/(n+1));
    }
}
