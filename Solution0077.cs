/*
Apr 22, 2023 22:22
Runtime 115 ms Beats 60.15%
Memory 44.3 MB Beats 30.83%
*/


public class Solution {
    public IList<IList<int>> Combine(int n, int k)
    {
        var res = new List<IList<int>>();
        var tmp = new List<int>();

        Backtracing(n, k, 0, res, tmp);

        return res;
    }

    private void Backtracing(int n, int k, int curr, List<IList<int>> list, List<int> tmp)
    {
        if (tmp.Count == k) { 
            list.Add(new List<int>(tmp));
            return;
        }

        for(int i = curr; i < n; i++) {
            tmp.Add(i + 1);
            Backtracing(n, k, i + 1, list, tmp);
            tmp.Remove(i + 1);
        }

    }
}
