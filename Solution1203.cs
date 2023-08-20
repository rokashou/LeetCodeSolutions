/*
Aug 20, 2023 23:12
Runtime 220 ms Beats 100%
Memory 61.3 MB Beats 90.91%
*/

// Hint 1: Think of it as a graph problem.
// Hint 2: We need to find a topological order on the dependency graph.
// Hint 3: Build two graphs, one for the groups and another for the items.

public class Solution {
    public int[] SortItems(int n, int m, int[] group, IList<IList<int>> beforeItems)
    {
        // if an item belongs to zero group, assign it a unique group id.
        int groupid = m;
        for(int i = 0; i < n; i++)
        {
            if (group[i] == -1)
            {
                group[i] = groupid;
                groupid++;
            }
        }

        // Sort all item regradless of group dependencies.
        Dictionary<int, List<int>> itemGraph = new Dictionary<int, List<int>>();
        int[] itemIndegree = new int[n];
        for (int i = 0; i < n; i++)
            itemGraph.Add(i, new List<int>());

        // Sort all groups regradless of item dependencies.
        var groupGraph = new Dictionary<int, List<int>>();
        int[] groupIndegree = new int[groupid];
        for (int i = 0; i < groupid; i++)
            groupGraph.Add(i, new List<int>());

        for(int curr = 0; curr < n; curr++)
        {
            foreach(var prev in beforeItems[curr])
            {
                // Each (prev -> curr) represents an edge in the item graph.
                itemGraph[prev].Add(curr);
                itemIndegree[curr]++;

                // if they belong to different groups, add an edge in the group graph.
                if (group[curr] != group[prev])
                {
                    groupGraph[group[prev]].Add(group[curr]);
                    groupIndegree[group[curr]]++;
                }
            }
        }

        // Topological sort nodes in the graph, return an empty array if a cycle exists.
        var itemOrder = TopologicalSort(itemGraph, itemIndegree);
        var groupOrder = TopologicalSort(groupGraph, groupIndegree);

        if(itemOrder.Count == 0 || groupOrder.Count == 0)
        {
            return new int[0];
        }

        // Items are sorted regardless of groups, we need to differentiate them by the groups they belong to.
        var orderedGroups = new Dictionary<int, List<int>>();
        foreach(var item in itemOrder)
        {
            if (!orderedGroups.ContainsKey(group[item]))
                orderedGroups.Add(group[item], new List<int>());
            orderedGroups[group[item]].Add(item);
        }

        // concatenate sorted items in all sorted groups.
        // [group 1, group 2, ...] -> [(item 1, item 2, ...), (item 1, item 2, ...),...]
        var answerList = new List<int>();
        foreach(var groupIndex in groupOrder)
        {
            if (orderedGroups.ContainsKey(groupIndex))
                answerList.AddRange(orderedGroups[groupIndex]);
        }

        return answerList.ToArray();

    }

    private List<int> TopologicalSort(Dictionary<int, List<int>> graph, int[] indegree)
    {
        var visited = new List<int>();
        var stack = new Stack<int>();
        foreach(var key in graph.Keys)
        {
            if (indegree[key] == 0)
                stack.Push(key);
        }

        while(stack.Count > 0)
        {
            var curr = stack.Pop();
            visited.Add(curr);
            foreach(var prev in graph[curr])
            {
                indegree[prev]--;
                if (indegree[prev] == 0)
                    stack.Push(prev);
            }
        }

        return visited.Count == graph.Count ? visited : new List<int>();

    }
}
