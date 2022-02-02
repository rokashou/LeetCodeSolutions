/*
Runtime: 435 ms, faster than 16.80% of C# online submissions for Best Time to Buy and Sell Stock.
Memory Usage: 46.4 MB, less than 50.71% of C# online submissions for Best Time to Buy and Sell Stock.
Uploaded: 02/03/2022 00:04
*/


public class Solution {
    public int MaxProfit(int[] prices) {
        int max = -1;
        int minvalue = int.MaxValue;
        int len = prices.Length;
        for (int i = 0; i < len;i++){
            minvalue = Math.Min(prices[i], minvalue);
            max = Math.Max(prices[i] - minvalue, max);
        }
        return max;
    }
}
