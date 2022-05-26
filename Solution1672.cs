/*
Runtime: 95 ms, faster than 76.64% of C# online submissions for Richest Customer Wealth.
Memory Usage: 37.8 MB, less than 43.43% of C# online submissions for Richest Customer Wealth.
Uploaded: 05/26/2022 21:40
*/

public class Solution {
    public int MaximumWealth(int[][] accounts) {
        int max = 0;
        foreach (var acc in accounts)
        {
            int sum = 0;
            foreach (var weal in acc)
            {
                sum += weal;
            }
            max = Math.Max(sum, max);
        }
        return max;
    }
}
