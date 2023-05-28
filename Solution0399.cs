/*
May 28, 2023 20:38
Runtime 150 ms Beats 81.85%
Memory 43 MB Beats 88.58%
*/

public class Solution {
    public double[] CalcEquation(IList<IList<string>> equations, double[] values, IList<IList<string>> queries) {
        double[] ans = new double[queries.Count];
        var graph = new Dictionary<string, Dictionary<string, double>>();

        for (int i = 0; i < equations.Count; ++i) {
            string a = equations[i][0];
            string b = equations[i][1];
            Dictionary<string, double> first;
            if (!graph.TryGetValue(a, out first)) {
                first = new Dictionary<string, double>();
                graph.Add(a, first);
            }
            first[b] = values[i];
            Dictionary<string, double> second;
            if (!graph.TryGetValue(b, out second)) {
                second = new Dictionary<string, double>();
                graph.Add(b, second);
            }
            second[a] = 1 / values[i];
        }

        for (int i = 0; i < queries.Count; i++) {
            IList<string> query = queries[i];
            string a = query[0];
            string c = query[1];
            if (!graph.ContainsKey(a) || !graph.ContainsKey(c))
                ans[i] = -1;
            else
                ans[i] = Divide(graph, a, c, new HashSet<string>());
        }
        return ans;
    }
    double Divide(Dictionary<string, Dictionary<string, double>> graph, string a, string c, HashSet<string> seen) {
        if (a == c)
            return 1.0;
        seen.Add(a);
        Dictionary<string, double> nodes;
        if (!graph.TryGetValue(a, out nodes))
            return -1;
        foreach (var item in graph[a]) {
            if (seen.Contains(item.Key))
                continue;
            double res = Divide(graph, item.Key, c, seen);
            if (res > 0)
                return item.Value * res;
        }
        return -1;
    }
}



/*
Runtime: 160 ms, faster than 78.92% of C# online submissions for Evaluate Division.
Memory Usage: 43.2 MB, less than 11.21% of C# online submissions for Evaluate Division.
Uploaded: 05/01/2022 01:16
*/



public class Solution {
    Dictionary<string, List<KeyValuePair<string, double>>> adjList;
    Dictionary<string, bool> visited;
    double queryAns;

    bool dfs(string startNode, string endNode, double runningProduct)
    {
        if (!adjList.ContainsKey(startNode))
            return false;
        if (!adjList.ContainsKey(endNode))
            return false;

        if(startNode == endNode && adjList.ContainsKey(startNode))
        {
            queryAns = runningProduct;
            return true;
        }

        bool tempAns = false;
        visited[startNode] = true;

        for(int i = 0; i < adjList[startNode].Count; i++)
        {
            if (!visited[adjList[startNode][i].Key])
            {
                tempAns = dfs(adjList[startNode][i].Key, endNode, runningProduct * adjList[startNode][i].Value);
                if (tempAns) break;
            }
        }

        visited[startNode] = false;

        return tempAns;
    }

    private bool AddToAdjList(string node, KeyValuePair<string,double> valuePair)
    {
        if (!adjList.ContainsKey(node))
        {
            adjList.Add(node, new List<KeyValuePair<string, double>>());
        }
        adjList[node].Add(valuePair);

        return true;
    }


    private bool AddToVisitedList(string node, bool value)
    {
        if (!visited.ContainsKey(node))
        {
            visited.Add(node, value);
        }
        return true;
    }

    public double[] CalcEquation(
        IList<IList<string>> equations,
        double[] values,
        IList<IList<string>> queries)
    {
        adjList = new Dictionary<string, List<KeyValuePair<string, double>>>();
        visited = new Dictionary<string, bool>();

        const int MaxLength = 40;
        int n = values.Length;
        int m = queries.Count;

        double[] ans = new double[m];

        for(int i = 0; i < n; i++)
        {
            AddToAdjList(equations[i][0],
                new KeyValuePair<string, double>(equations[i][1], values[i]));
            AddToAdjList(equations[i][1],
                new KeyValuePair<string, double>(equations[i][0], 1 / values[i]));
            AddToVisitedList(equations[i][0], false);
            AddToVisitedList(equations[i][1], false);
        }

        for(int i = 0; i < m; i++)
        {
            queryAns = 1;
            bool pathFound = dfs(queries[i][0], queries[i][1], 1);
            if (pathFound) ans[i] = queryAns;
            else ans[i] = -1;
        }

        return ans;

    }
}
