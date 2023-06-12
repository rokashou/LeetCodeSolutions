/*
Jun 12, 2023 21:53
Runtime 149 ms Beats 82.29%
Memory 43.2 MB Beats 77.12%
*/

public class Solution {
    public IList<string> SummaryRanges(int[] nums) {
        var result = new List<string>();

        for (int i = 0; i < nums.Length; i++)
        {
            int start = nums[i];

            while (i + 1 < nums.Length && nums[i] == nums[i + 1] - 1)
                i++;

            if (start != nums[i])
                result.Add(string.Format("{0}->{1}", start, nums[i]));
            else
                result.Add(string.Format("{0}", start));
        }

        return result;
    }
}
