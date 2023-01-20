/*
Runtime 181 ms, Beats 100%
Memory 62.3 MB, Beats 50%
Accepted: Jan 20, 2023 13:19
*/

public class Solution {
    private void Backtrack(int[] nums, int index, List<int> sequence, HashSet<IList<int>> result)
    {
        if (sequence.Count > 1) result.Add(sequence.ToList());

        var unique = new HashSet<int>();
        for(int i=index; i < nums.Length; i++)
        {
            if (index > 0 && nums[i] < nums[index - 1]) continue; // skip non-increase
            if (unique.Contains(nums[i])) continue; // skip duplicate
            unique.Add(nums[i]);
            sequence.Add(nums[i]);
            Backtrack(nums, i + 1, sequence, result);
            sequence.RemoveAt(sequence.Count - 1);
        }
    }

    public IList<IList<int>> FindSubsequences(int[] nums)
    {
        HashSet<IList<int>> result = new HashSet<IList<int>>();
        List<int> sequence = new List<int>();
        Backtrack(nums, 0, sequence, result);
        return result.ToList();
    }
}
