/*
Apr 25, 2023 22:56
Runtime 92 ms Beats 55.47%
Memory 41.9 MB Beats 82.81%
*/

public class Solution {
    public int NumberOfArrays(string s, int k) {
        int mod = 1000000007;
        int n = s.Length;
        long[] dp = new long[n+1];
        dp[n] = 1;
        for (int i = n-1; i >= 0; i--) {
            if (s[i] == '0') {
                dp[i] = 0;
            } else {
                long num = 0;
                for (int j = i; j < n; j++) {
                    num = num * 10 + (s[j] - '0');
                    if (num > k) break;
                    dp[i] = (dp[i] + dp[j+1]) % mod;
                }
            }
        }
        return (int) dp[0];   
    }
}
