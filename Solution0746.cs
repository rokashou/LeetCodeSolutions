/*
Runtime: 189 ms, faster than 5.10% of C# online submissions for Min Cost Climbing Stairs.
Memory Usage: 37.8 MB, less than 76.50% of C# online submissions for Min Cost Climbing Stairs.
Uploaded: 07/10/2022 09:28
*/


public class Solution {
    public int MinCostClimbingStairs(int[] cost) {
        int n = cost.Length;
        int first = cost[0];
        int second = cost[1];
        if (n <= 2) return Math.Min(first, second);

        for(int i = 2; i < n; i++)
        {
            int curr = cost[i] + Math.Min(first, second);
            first = second;
            second = curr;
        }

        return Math.Min(first, second);
    }
}
