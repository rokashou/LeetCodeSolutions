/*
Jul 13, 2023 23:20
Runtime 111 ms Beats 85.77%
Memory 44.5 MB Beats 80.28%
*/

public class Solution {
    public bool dfs(int node, List<List<int>> adj, bool[] visit, bool[] inStack) {
        // if the node is already in the stack, we have a cycle.
        if (inStack[node]) return true;
        if (visit[node]) return false;

        // mark the current node as visited and part of current recursion stack.
        visit[node] = true;
        inStack[node] = true;
        foreach(var neighbor in adj[node]) {
            if (dfs(neighbor, adj, visit, inStack)) return true;
        }
        // remove the node from the stack
        inStack[node] = false;
        return false;
    }

    public bool CanFinish(int numCourses, int[][] prerequisites)
    {
        var adj = new List<List<int>>();
        for(int i = 0; i < numCourses; i++) {
            adj.Add(new List<int>());
        }

        for(int i = 0; i < prerequisites.Length; i++) {
            adj[prerequisites[i][1]].Add(prerequisites[i][0]);
        }

        bool[] visit = new bool[numCourses];
        bool[] inStack = new bool[numCourses];
        for(int i = 0; i < numCourses; i++) {
            if (dfs(i, adj, visit, inStack)) return false;
        }

        return true;
    }
}
