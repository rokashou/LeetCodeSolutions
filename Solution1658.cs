/*
Runtime: 457 ms, faster than 19.23% of C# online submissions for Minimum Operations to Reduce X to Zero.
Memory Usage: 61.2 MB, less than 7.69% of C# online submissions for Minimum Operations to Reduce X to Zero.
Uploaded: 06/11/2022 19:52
*/

public class Solution {
    public int MinOperations(int[] nums, int x) {
        int target = -x;
        foreach(var num in nums)
        {
            target += num;
        }

        if (target == 0) return nums.Length; // since all elements are positive, we have to take all of them

        Dictionary<int, int> map = new Dictionary<int, int>();
        map.Add(0, -1);
        int sum = 0;
        int res = int.MinValue;

        for(int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
            if(map.ContainsKey(sum-target))
            {
                res = Math.Max(res, i - map[sum - target]);
            }

            // no need to check containKey since sum is unique
            map.Add(sum, i);
        }

        return res == int.MinValue ? -1 : nums.Length - res;
    }
}
