/*
Runtime: 136 ms, faster than 59.97% of C# online submissions for Coin Change.
Memory Usage: 39.5 MB, less than 85.94% of C# online submissions for Coin Change.
Uploaded: 05/21/2022 21:55
*/

public class Solution {
    public int CoinChange(int[] coins, int amount)
    {
        if (amount == 0) return 0;
        int n = coins.Length;
        // initializing each index with (1+amount) which is 1 greater than max possible answer
        int[] dp = new int[amount + 1];
        Array.Fill<int>(dp, amount + 1);
        Array.Sort<int>(coins);
        dp[0] = 0; // 0 amount can be formed with 0 amount of coins
        // take each amount and try each coin for that amount to find minimum coins required for that amount.
        for(int curr = 1; curr <= amount; curr++)
        {
            foreach(var coin in coins)
            {
                if (coin <= curr)
                {
                    // only update dp[curr] if coin value is not greater than that current amount.
                    // either take the current coin under consideration & update or keep dp[curr] same
                    dp[curr] = Math.Min(dp[curr], 1 + dp[curr - coin]);
                }
            }
        }

        // if is greater than amount than amount, return -1, since to form any amount we should not need more than amount number of coins
        return dp[amount] > amount ? -1 : dp[amount];
    }
}
