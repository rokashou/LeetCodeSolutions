/*
Jun 25, 2023 22:50
Runtime 253 ms Beats 50%
Memory 40.6 MB Beats 83.33%
*/

public class Solution {
    public int CountRoutes(int[] locations, int start, int finish, int fuel) {
        int n = locations.Length;
        int[,] dp = new int[n, fuel + 1];
        for(int i = 0; i <= fuel; i++) {
            dp[finish, i] = 1;
        }

        int ans = 0;
        for(int j = 0; j <= fuel; j++) {
            for(int i = 0; i < n; i++) {
                for(int k = 0; k < n; k++) {
                    if (k == i) continue;
                    int _abs = Math.Abs(locations[i] - locations[k]);
                    if (_abs <= j) {
                        dp[i, j] = (dp[i, j] + dp[k, j - _abs]) % 1_000_000_007;
                    }
                }
            }
        }

        return dp[start, fuel];
    }
}
