/*
Apr 13, 2023 22:30
Runtime 137 ms, Beats 88.98%
Memory 43.6 MB, Beats 34.25%
*/

public class Solution {
    private void Backtrack(int[] candidates, int curr, int target, List<int> tmp, IList<IList<int>> res)
    {
        if(target == 0)
        {
            res.Add(new List<int>(tmp));
            return;
        }

        for(int i = curr; i<candidates.Length;i++)
        {
            if (i > curr && candidates[i] == candidates[i - 1])
                continue;
            if (target - candidates[i] < 0) break;

            tmp.Add(candidates[i]);
            Backtrack(candidates, i + 1, target - candidates[i], tmp, res);
            tmp.RemoveAt(tmp.Count - 1);
        }
    }

    public IList<IList<int>> CombinationSum2(int[] candidates, int target)
    {
        var res = new List<IList<int>>();
        var tmp = new List<int>();

        Array.Sort(candidates);
        Backtrack(candidates, 0, target, tmp, res);

        return res;
    }
}
