/*

Runtime: 316 ms, faster than 10.02% of C# online submissions for Permutations II.
Memory Usage: 44.2 MB, less than 68.37% of C# online submissions for Permutations II.
Uploaded: 05/12/2022 23:04

*/


public class Solution {
    public IList<IList<int>> PermuteUnique(int[] nums)
    {
        IList<IList<int>> result = new List<IList<int>>();
        Array.Sort(nums);
        bool[] used = new bool[nums.Length];
        Backtracking(nums, new List<int>(), result, used);
        return result;            
    }

    private void Backtracking(int[] nums, List<int> list, IList<IList<int>> res, bool[] used)
    {
        if(list.Count == nums.Length)
        {
            res.Add(new List<int>(list));
            return;
        }
        else
        {
            for(int i = 0; i < nums.Length; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1] && used[i - 1] || used[i]) continue;

                list.Add(nums[i]);
                used[i] = true;
                Backtracking(nums, list, res, used);
                list.RemoveAt(list.Count - 1);
                used[i] = false;
            }
        }
    }
}

