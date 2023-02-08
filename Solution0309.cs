/*
Runtime 88 ms, Beats 80.70%
Memory 38.5 MB, Beats 54.53%
Accept Feb 08, 2023 21:11
*/

public class Solution {
    public int MaxProfit(int[] prices) {
        int sold = 0, hold = int.MinValue, rest = 0;
        for(int i = 0; i < prices.Length; i++)
        {
            int prvSold = sold;
            sold = hold + prices[i];
            hold = Math.Max(hold, rest - prices[i]);
            rest = Math.Max(rest, prvSold);
        }
        return Math.Max(sold, rest);

    }
}

