/*
Apr 04, 2023 23:13
Runtime 153 ms, Beats 50.82%
Memory 46.7 MB, Beats 96.72%
*/

public class Solution {
    public IList<IList<int>> FindMatrix(int[] nums) {
        var ans = new List<IList<int>>();
        ans.Add(new List<int>());
        foreach(var n in nums)
        {
            int i = 0;
            for(; i < ans.Count; i++)
            {
                if (!ans[i].Contains(n))
                {
                    ans[i].Add(n);
                    break;
                }
            }
            if (i == ans.Count)
            {
                ans.Add(new List<int>() { n });
            }
        }
        return ans;
    }
}
