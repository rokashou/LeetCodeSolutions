/*
Apr 21, 2023 23:50
Runtime 384 ms Beats 50%
Memory 42.7 MB Beats 50%
*/

public class Solution {
    int mod = 1_000_000_007;
    int[,,] memo = new int[101, 101, 101];

    int find(int pos, int count, int profit, int n, int minProfit, int[] group, int[] profits)
    {
        if (pos == group.Length)
        {
            // if profit exceeds the minimum required; it's a profitable scheme.
            return profit >= minProfit ? 1 : 0;
        }

        if (memo[pos, count, profit] != -1)
        {
            // Repeated subproblem, return the stored answer.
            return memo[pos, count, profit];
        }

        // Ways to get a profitable scheme without this crime.
        int totalWays = find(pos + 1, count, profit, n, minProfit, group, profits);
        if (count + group[pos] <= n)
        {
            // Adding ways to get profitable schemems, including this crime.
            totalWays += find(pos + 1, count + group[pos], Math.Min(minProfit, profit + profits[pos]), n, minProfit, group, profits);
        }

        return memo[pos, count, profit] = totalWays % mod;
    }

    private void initMemoArray() {
        for(int i = 0; i < 101; i++)
            for (int j = 0; j < 101; j++)
                for (int k = 0; k < 101; k++)
                    memo[i, j, k] = -1;
    }

    public int ProfitableSchemes(int n, int minProfit, int[] group, int[] profit)
    {
        // initializing all states as -1.
        initMemoArray();

        return find(0, 0, 0, n, minProfit, group, profit);
    }
}
