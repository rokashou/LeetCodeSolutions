/*
Jun 17, 2023 00:08
Runtime 252 ms Beats 100%
Memory 70 MB Beats 50%
*/

public class Solution {
    private long MOD = 1_000_000_007;
    private long[,] table;

    public int NumOfWays(int[] nums)
    {
        int m = nums.Length;

        table = new long[m,m];
        for(int i = 0; i < m; i++)
        {
            table[i,0] = table[i,i] = 1;
        }
        for(int i = 2; i < m; i++)
        {
            for(int j = 1; j < i; j++)
            {
                table[i, j] = (table[i - 1, j - 1] + table[i - 1, j]) % MOD;
            }
        }
        List<int> arrList = new List<int>(nums);
        return (int) ((dfs(arrList) - 1) % MOD);
    }

    private long dfs(List<int> nums)
    {
        int m = nums.Count;
        if (m < 3)
        {
            return 1;
        }

        var leftNodes = new List<int>();
        var rightNodes = new List<int>();
        for(int i = 1; i < m; i++)
        {
            if (nums[i] < nums[0])
                leftNodes.Add(nums[i]);
            else
                rightNodes.Add(nums[i]);
        }
        long leftWays = dfs(leftNodes) % MOD;
        long rightWays = dfs(rightNodes) % MOD;

        return (((leftWays * rightWays) % MOD) * table[m - 1, leftNodes.Count]) % MOD;
    }
}
