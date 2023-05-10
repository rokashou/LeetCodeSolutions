/*
May 11, 2023 00:17
Runtime 142 ms Beats 66.82%
Memory 43.3 MB Beats 36.36%
*/


public class Solution {
    void DFS(List<IList<int>> res, int[] nums, int pos, List<int> tmp)
    {
        res.Add(tmp);

        for (var i = pos; i < nums.Length; i++)
        {
            var subset = new List<int>(tmp.Count + 1);

            if (i <= pos || nums[i] != nums[i - 1])
            {
                subset.AddRange(tmp);
                subset.Add(nums[i]);
                DFS(res, nums, i + 1, subset);
            }
        }
    }

    public IList<IList<int>> SubsetsWithDup(int[] nums)
    {
        Array.Sort(nums);

        var res = new List<IList<int>>();

        DFS(res,nums,0,new List<int>());

        return res;
    }
}
