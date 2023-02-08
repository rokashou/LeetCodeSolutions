/*
Runtime 166 ms, Beats 60%
Memory 43.3 MB, Beats 40%
Accept Feb 08, 2023 22:26
*/

public class Solution {
    public IList<int> LargestDivisibleSubset(int[] nums) {
        Array.Sort(nums);
        int n = nums.Length, max_i = 0;

        List<int> result  = new List<int>();

        // initially dp[i]=1 since we can always form subset of size=1 ending at i.
        // pred[i]=-1 because we have not found any predecessors for any subset yet.
        int[] dp = new int[n];
        int[] pred = new int[n];
        Array.Fill(dp,1);
        Array.Fill(pred,-1);
        

        for(int i = 1; i < n; i++)
        {
            for(int j = 0; j < i; j++)
            {
                // nums[i] should divide nums[j] if it is to be included in its subset (i.e. dp[j])
                // only include nums[i] in subset ending at j if resultant subset size (dp[j]+1) is larget than already possible (dp[i])
                if (nums[i] % nums[j] == 0 && dp[i] < (dp[j] + 1)) {
                    dp[i] = dp[j] + 1;
                    pred[i] = j; // jth element will be predecessor to subset ending at ith element
                }
            }
            if (dp[i] > dp[max_i]) max_i = i; // keep track of index where largest subset ends
        }
        // start with index where largest subset ended. Reconstruct from that point to the start
        for(; max_i >= 0; max_i = pred[max_i])
        {
            result.Add(nums[max_i]);
        }

        return result;
    }
}
