/*
Apr 15, 2023 12:15
Runtime 293 ms Beats 83.33%
Memory 49.8 MB Beats 16.67%
*/


public class Solution {
    public int MaxValueOfCoins(IList<IList<int>> piles, int k)
    {
        int n = piles.Count;
        int h = piles.Max(p => p.Count);
        var memo = new int?[n, k];
        int f(int x, int y) {
            if (x == n || y == k) {
                return 0;
            }
            if (memo[x, y].HasValue) {
                return memo[x, y].Value;
            }
            int max = f(x + 1, y);
            int sum = 0;
            for (int z = 0; y + z < k && z < piles[x].Count; z++) {
                sum += piles[x][z];
                max = Math.Max(max, sum + f(x + 1, y + z + 1));
            }
            memo[x, y] = max;
            return max;
        }
        return f(0, 0);
    }
}
