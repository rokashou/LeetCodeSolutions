/*
Apr 11, 2023 23:21
Runtime 159 ms Beats 45.69%
Memory 51.9 MB Beats 67.67%
*/

public class Solution {
    public IList<IList<int>> AllPathsSourceTarget(int[][] graph)
    {
        var result = new List<IList<int>>();
        var tmp = new List<int>();
        tmp.Add(0);
        DFS(graph, 0, result, tmp);

        return result;
    }

    private void DFS(int[][] graph, int node, IList<IList<int>> result, List<int> tmp)
    {
        if(node == graph.Length - 1)
        {
            result.Add(new List<int>(tmp));
            return;
        }

        foreach(var nextNode in graph[node])
        {
            tmp.Add(nextNode);
            DFS(graph, nextNode, result, tmp);
            tmp.RemoveAt(tmp.Count-1);
        }
    }
}
