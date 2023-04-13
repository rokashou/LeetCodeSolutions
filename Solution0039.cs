/*
Apr 13, 2023 22:07
Runtime 142 ms, Beats 81.1%
Memory 43 MB, Beats 97.87%
*/

public class Solution {
    private void DP(int[] candidates,int startIdx, int target, List<int> tmp, IList<IList<int>> res)
    {
        if(target == 0)
        {
            res.Add(new List<int>(tmp));
            return;
        }
        while(startIdx >= 0)
        {
            if(target >= candidates[startIdx])
            {
                tmp.Add(candidates[startIdx]);
                DP(candidates, startIdx, target - candidates[startIdx], tmp, res);
                tmp.RemoveAt(tmp.Count - 1);
            }
            startIdx--;
        }
    }

    public IList<IList<int>> CombinationSum(int[] candidates, int target)
    {
        List<IList<int>> res = new List<IList<int>>();
        List<int> tmp = new List<int>();
        DP(candidates, candidates.Length-1, target, tmp, res);

        return res;
    }
}
