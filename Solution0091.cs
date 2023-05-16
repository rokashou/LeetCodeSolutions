/*
May 16, 2023 22:37
Runtime 63 ms Beats 71.57%
Memory 36.6 MB Beats 60.78%
*/

public class Solution {
    public int NumDecodings(string s) {
        int[] dp = new int[s.Length + 1];
        dp[s.Length] = 1;
        for(int i = s.Length -1; i >= 0; i--)
        {
            if(s[i] == '0') 
                dp[i] = 0;
            else 
                dp[i] += dp[i+1];

            if(i + 1 < s.Length && (s[i] == '1' || (s[i]=='2' && s[i + 1] >= '0' && s[i + 1]<='6')))
                dp[i] += dp[i + 2];
        }
        return dp[0];
    }
}
