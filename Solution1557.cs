/*
May 18, 2023 21:55
Runtime 490 ms Beats 25%
Memory 68.8 MB Beats 73.33%
*/

public class Solution {
    public IList<int> FindSmallestSetOfVertices(int n, IList<IList<int>> edges) {
        bool[] isTarget = new bool[n];
        for(int i=0;i<edges.Count;i++)
            isTarget[edges[i][1]] = true;
        
        List<int> ans = new List<int>();
        for (int i = 0; i < n; i++)
            if (!isTarget[i]) ans.Add(i);

        return ans;
    }
}
